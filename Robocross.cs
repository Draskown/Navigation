using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Navigation;

public partial class Robocross : Form
{
    // Create global fields
    private UdpClient udpClient;
    private Thread thread;
    private bool connOpened;
    private string localIP;
    private int localPort;
    private IPEndPoint remoteIP;
    private int remotePort;
    private string message;

    // Structures for robot's data and message to it
    private struct RobotData{
        public string n {get; set;}
        public string d0 { get; set; }
        public string d1 { get; set; }
        public string d2 { get; set; }
        public string d3 { get; set; }
        public string d4 { get; set; }
        public string d5 { get; set; }
        public string d6 { get; set; }
        public string d7 { get; set; }
        public string az { get; set; }
        public string le { get; set; }
        public string re { get; set; }
        public string c { get; set; }
        public string b { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public string t { get; set; }
        public string l0 { get; set; }
        public string l1 { get; set; }
        public string l2 { get; set; }
        public string l3 { get; set; }
        public string l4 { get; set; }
    }

    private struct RobotMsg{
        public int N { get; set; }
        public int M { get; set; }
        public int F { get; set; }
        public int B { get; set; }
        public int T { get; set; }
    }

    private RobotData rData;
    private RobotMsg rMsg;
    private bool moveActive;
    private int mode, backwards, encMult;
    private int d0, d1, d2, d6, d7;
    private int  re, re_to;
    private double t;
    private double error;
    private double turnTolerance;
    private double encodersMoveValue;

    // Handle the Form
    public Robocross()
    {
        // Init all the components on the form
        InitializeComponent();

        rData = new RobotData();
        rMsg = new RobotMsg();

        localIP = "127.0.0.1";
        localPort = 7777;
        remoteIP = new IPEndPoint(IPAddress.Any, 0);
        remotePort = 8888;

        message = "";

        udpClient = new UdpClient(localPort);
        thread = new Thread(new ThreadStart(ReceiveData));
        connOpened = false;

        this.numN.Value = 0;

        moveActive = false;

        mode = 0;
        backwards = 0;
        d0 = d1 = d2 = d6 = d7 = 0;
        re = re_to = 0;
        t = error = 0.0;
        encMult = 1;

        turnTolerance = 0.3;
        encodersMoveValue = 130;
    }

    #region Events
    // Move robot according to the task
    private void MoveRobot(object sender, EventArgs e){
        if (!moveActive) {
            this.timer.Start();
            this.moveBtn.Text = "Stop";
            moveActive = true;
        }
        else {
            this.timer.Stop();
            this.moveBtn.Text = "Move";
            moveActive = false;
        }
    }

    // Reset the numeric fields
    private void ResetNums(object sender, EventArgs e){
        this.numM.Value = 0;
        this.numF.Value = 0;
        this.numB.Value = 0;
        this.numT.Value = 0;
    }

    // Start or close UDP connection
    private void StartBtn_Click(object sender, EventArgs e){
        if (!connOpened) {
            try {
                connOpened = true;
                thread.IsBackground = true;
                thread.Start();
                PrintLog("UDPClient has been started");
            }
            catch (Exception ex){
                PrintLog($"UDPClient's start failed: {ex}");
            }
            
            this.startBtn.Enabled = false;
            this.startBtn.BackColor = Color.Gray;
        }
    }

    // Send messages to the Sim
    private void SendBtn_Click(object sender, EventArgs e){
        if (connOpened) {
            SendData();

            rMsg.N++;
            GetMsg();
        }
    }

    // Handle the changing of numeric values
    private void Num_ValueChanged(object sender, EventArgs e){
        var num = (NumericUpDown)sender;

        switch (num.Name){
            case "numN":
                rMsg.N = (int)num.Value;
                break;
            case "numM":
                rMsg.M = (int)num.Value;
                break;
            case "numF":
                rMsg.F = (int)num.Value;
                break;
            case "numB":
                rMsg.B = (int)num.Value;
                break;
            case "numT":
                rMsg.T = (int)num.Value;
                break;
        }
    }

    // Handle timer ticking
    private void timer_Tick(object sender, EventArgs e){
        d0 = Convert.ToInt16(rData.d0);
        d1 = Convert.ToInt16(rData.d1);
        d2 = Convert.ToInt16(rData.d2);
        d6 = Convert.ToInt16(rData.d6);
        d7 = Convert.ToInt16(rData.d7);
        t = Convert.ToDouble(rData.t);
        re = Convert.ToInt32(rData.re);

        switch (mode){
            // Debug case
            case -1:
                if (Math.Abs(t - 180.0 - 180.0) > turnTolerance){
                    error = t - 180.0 - 180.0;

                    double initOverturn = 180.0 == 0.0 ? 360.0 : 180.0;

                    if (error > 200.0 + 180.0*1*-1)
                        error -= initOverturn + 180.0*1*-1;

                    int b = Convert.ToInt16(((error)));
                    
                    if (b == 0)
                        rMsg.B = -1;
                    else
                        rMsg.B = b;
                }
            break;
            
            // Move forward till the line
            case 0:
                rMsg.F = 100;
                
                encMult = 2;
                CheckLine();
            break;
            
            // Move forward till the wall
            case 1:
                if (d0 > 30){
                    rMsg.B = 0;
                    rMsg.F = 100;

                    // If the line is seen again - turn around
                    CheckLine();
                    
                    // Correct the direction
                    CorrectDir(90.0, 110.0);

                    // Move robot off the wall if one's detected
                    if (d1 < 40 || d2 < 15){
                        rMsg.B += 5;
                    } else if (d7 < 60 || d6 < 15){
                        rMsg.B += -5;
                    }

                // Once the wall has been spotted
                } else {
                    rMsg.F = 0;

                    // Decide where to go
                    if (d6 > d2)
                        mode = 2;
                    else
                        mode = 3;
                }
            break;
            
            // If d6 > d2 - turn left
            case 2:
                CorrectDir(0.0, 340.0, -1);
            break;
            
            // if d6 < d2 - turn right
            case 3:
                CorrectDir(180.0, 200.0, -1);
            break;
            
            // Move forward till d2 has distance
            case 4:
                MoveForwardTillDistance(d2);
                CorrectDir(0.0, 340.0, -1);
            break;
            
            // Move more forward using encoders values
            // To prevent collision
            case 5:
                MoveEnc();
            break;
            
            // Turn to move forward
            case 6:
                CorrectDir(90.0, 110.0);
            break;
            
            // Move forward till d6 has distance
            case 7:
                CorrectDir(180.0, 200.0, -1);
                MoveForwardTillDistance(d6);
            break;
            
            // After the line's been detected - 
            // Move a little forward beyond it
            case 8:
                MoveEnc();
            break;
            
            // Turn around
            case 9:
                CorrectDir(270.0, 290.0);
            break;
            
            // Stop after complition
            case 10:
                rMsg.F = 0;
                rMsg.B = 0;
            break;
        }
        
        SendData();
    }
    #endregion


    #region Methods
    // Handling of the separate task
    private void ReceiveData(){
        while (connOpened){
            try {
                byte[] content = udpClient.Receive(ref remoteIP);

                if (content.Length > 0){
                    message = Encoding.ASCII.GetString(content);

                    this.Invoke(() => {
                        try{
                            rData = JsonSerializer.Deserialize<RobotData>(message);
                            PrintLog(message);
                            FillLabels();
                        } catch{
                            PrintLog("Incorrect message");
                        }
                    });
                }
            } catch (Exception ex){
                this.Invoke(() => PrintLog($"Error receiving data: {ex}"));
            }
        }
    }

    // Send data to the Sim
    private void SendData(){
        rMsg.N++;

        IPAddress ip = IPAddress.Parse(localIP.Trim());
        IPEndPoint ipEndPoint = new IPEndPoint(ip, remotePort);

        string text = JsonSerializer.Serialize<RobotMsg>(rMsg) + "\n";
        
        byte[] content = Encoding.ASCII.GetBytes(text);
        
        try{
            if (udpClient.Send(content, content.Length, ipEndPoint) > 0)
                PrintLog("Sent message:" + text);
            GetMsg();            
        } catch (Exception ex){
            PrintLog($"Error has occured: {ex}");
        }
    }

    // Add messages to the ListBox
    private void PrintLog(string msg){
        this.listBox.Items.Add(msg);

        if (this.listBox.Items.Count > 20){
            this.listBox.Items.RemoveAt(0);
        }
        this.listBox.SelectedIndex = this.listBox.Items.Count - 1;
    }

    // Fills the labels from struct
    private void FillLabels(){
        this.d0Label.Text = rData.d0;
        this.d1Label.Text = rData.d1;
        this.d2Label.Text = rData.d2;
        this.d3Label.Text = rData.d3;
        this.d4Label.Text = rData.d4;
        this.d5Label.Text = rData.d5;
        this.d6Label.Text = rData.d6;
        this.d7Label.Text = rData.d7;
        this.azLabel.Text = rData.az;
        this.leLabel.Text = rData.le;
        this.reLabel.Text = rData.re;
        this.cLabel.Text = rData.c;
        this.bLabel.Text = rData.b;
        this.xLabel.Text = rData.x;
        this.yLabel.Text = rData.y;
        this.tLabel.Text = rData.t;
        this.l0Label.Text = rData.l0;
        this.l1Label.Text = rData.l1;
        this.l2Label.Text = rData.l2;
        this.l3Label.Text = rData.l3;
        this.l4Label.Text = rData.l4;
        this.numN.Value = Int32.Parse(rData.n);
    }

    // Fill the numerics according to the sent msg
    private void GetMsg(){
        this.numN.Value = rMsg.N;
        this.numM.Value = rMsg.M;
        this.numF.Value = rMsg.F;
        this.numB.Value = rMsg.B;
        this.numT.Value = rMsg.T;
    }
    
    // Checks if the line is detected
    private void CheckLine(){
        if (rData.l0 == "0" && rData.l1 == "0" && rData.l2 == "0" && rData.l3 == "0" && rData.l4 == "0"){   
            re_to = Convert.ToInt32(rData.re);
            
            if (mode == 0)
                mode = 5;
            else
                mode = 8;
        }
    }

    // Corrects the desired direction
    private void CorrectDir(double course, double overTurn, int caseMult = 1){
        if (Math.Abs(t - course - 180.0*backwards) > turnTolerance){
            error = t - course - 180.0*backwards;

            double initOverturn = course == 0.0 ? 360.0 : course;

            if (error > overTurn + 180.0*backwards*caseMult)
                error -= initOverturn + 180.0*backwards*caseMult;

            int b = Convert.ToInt16(((error)));
            
            if (b == 0)
                rMsg.B = caseMult;
            else
                rMsg.B = b;
        }

        else{
            rMsg.B = 0;

            switch (mode){
                case 2:
                    mode = 4;
                break;

                case 3:
                    mode = 7;
                break;

                case 6:
                    mode = 1;
                break;

                case 9:
                    mode = 1;
                    backwards = 1;
                break;
            }
        }
    }

    // Moves forward until distance to the left or right
    // Is sufficient
    private void MoveForwardTillDistance(int d){        
        if (d0 > 30){
            rMsg.B = 0;
            rMsg.F = 100;
            
            if (d > 30){
                re_to = Convert.ToInt32(rData.re);
                mode = 5;
            }
        }
    }

    // Move forward with encoders
    private void MoveEnc(){
        if (re < re_to + encodersMoveValue*encMult){
            rMsg.B = 0;
            rMsg.F = 100;
        }
        else{
            rMsg.F = 0;
            encMult = 1;
            
            // Once that's done - 
            // Turn to the desired direction
            // Moving forward (90.0) or backwards (270.0)
            if (mode == 5)
                mode = 6;
            else {
                // If the robot was moving backwards - 
                // Stop it
                if (backwards == 0)
                    mode = 9;
                else
                    mode = 10;
            }
        }
    }
    #endregion
}
