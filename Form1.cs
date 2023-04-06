using System.Net;
using System.Net.Sockets;

namespace Navigation;

public partial class Form1 : Form
{
    // Create global udpClient field
    private UdpClient udpClient;

    // Handle the Form
    public Form1()
    {
        // Init all the components on the form
        InitializeComponent();
    }

    // 
    private void Form1_Load(object sender, EventArgs e){
        
    }

    //
    private void startBtn_Click(object sender, EventArgs e){

    }

    //
    private void sendBtn_Click(object sender, EventArgs e){

    }

    // Handle the changing of numeric values
    private void num_ValueChanged(object sender, EventArgs e){
        var num = (NumericUpDown)sender;

        switch (num.Name){
            case "numN":
                break;
            case "numM":
                break;
            case "numF":
                break;
            case "numB":
                break;
            case "numT":
                break;
        }
    }


    // Handling of the separate task
    private async void ReceiveData(){
        try{
            // Infinite loop that gets messages from the server
            while(true){
                // Receives the message asynchronously
                var result = await udpClient.ReceiveAsync();
                // Invoke the ListBox action to add items to the list
                this.listBox.Invoke((Action) (() => this.listBox.Items.Add(result)));
            }
        } catch (Exception ex){
            // In case of an error -> add it to the list as well
            this.listBox.Invoke((Action) (() => this.listBox.Items.Add($"Error receiving UDP data ({ex.Message})")));
        }
    }
}
