using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace Navigation;

public partial class Form2 : Form
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

    private int autoN;
    private bool moveActive;
    private int mode;

    // Handle the Form
    public Form2()
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

        this.numN.Value = 1;

        autoN = 0;
        moveActive = false;

        mode = 0;
    }

    #region Events
    // Move robot according to the task
    private void MoveRobot(object sender, EventArgs e){
        if (!moveActive) {
            autoN = 0;
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
        switch (mode) {
            case 0:
                rMsg.B = -50;
                rMsg.N++;
                SendData();
                mode = 1;
                break;
            case 1:
                if (Convert.ToInt16(rData.d2) < 25) {
                    rMsg.B = 0;
                    rMsg.N++;
                    SendData();
                    mode = 2;
                }
                break;
            case 2:
                if (Convert.ToInt16(rData.d0) > 30 && rData.b=="0") {
                    if (Convert.ToInt16(rData.d2) < 20) {
                        rMsg.B = 20;

                        if (Convert.ToInt16(rData.d1) < 40)
                            rMsg.F = 0;
                        else
                            rMsg.F = 100;
                        
                        rMsg.N++;
                        SendData();
                    }
                    else if (Convert.ToInt16(rData.d2) > 30) {
                        rMsg.B = -20;
                        if (Convert.ToInt16(rData.d1) > 60)
                        {
                            rMsg.F = 0;
                        }
                        else
                        {
                            rMsg.F = 100;
                        }
                        rMsg.N++;
                        SendData();
                    }
                    else {
                        rMsg.B = 0;
                        rMsg.F = 100;
                        rMsg.N++;
                        SendData();
                    }
                }
                else {
                    rMsg.B = 30;
                    rMsg.F = 0;
                    rMsg.N++;
                    SendData();
                }
                break;
        }
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
        IPAddress ip = IPAddress.Parse(localIP.Trim());
        IPEndPoint ipEndPoint = new IPEndPoint(ip, remotePort);

        string text = JsonSerializer.Serialize<RobotMsg>(rMsg) + "\n";
        
        byte[] content = Encoding.ASCII.GetBytes(text);
        
        try{
            if (udpClient.Send(content, content.Length, ipEndPoint) > 0)
                PrintLog("Sent message:" + text);
            
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
    #endregion
}
