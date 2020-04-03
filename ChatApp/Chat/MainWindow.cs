using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Net;

namespace Chat
{
    
    public partial class MainWindow : Form
    {
        TcpClient clientSocket = new TcpClient();
        NetworkStream serverStream = default(NetworkStream);
        string readData = null;
        string myIP = Dns.GetHostByName(Dns.GetHostName()).AddressList[0].ToString();
        Thread clientThread;
        Point PanelMouseDownLocation;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void minimizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PanelMouseDownLocation = e.Location;
            }
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - PanelMouseDownLocation.X;

                this.Top += e.Y - PanelMouseDownLocation.Y;
            }
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (serverStream != null)
            {
                serverStream.Close();
                clientSocket.Close();
            }
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private async void MainWindow_Load(object sender, EventArgs e)
        {
            fullnameTxt.Text = LoginForm.fullName;
            string firstName = LoginForm.firstName;
            string userID = LoginForm.userID;
            await establishConnection();
        }

        public async Task establishConnection()
        {
            loadingImg.Show();
            reconnectBtn.Visible = false;
            await Task.Run(() => connection(clientSocket, myIP, 8888));
            if (clientSocket.Connected == true)
            {
                message();
                serverStream = clientSocket.GetStream();
                byte[] outStream = Encoding.ASCII.GetBytes(fullnameTxt.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                clientThread = new Thread(getMessage);
                clientThread.Start();
                chatTxt.Visible = true;
                sendBtn.Visible = true;
                reconnectBtn.Visible = false;
            }
            else 
            { 
                reconnectBtn.Visible = true;
            }
            loadingImg.Hide();
        }

        public void connection(TcpClient clientSocket, string IP, int port)
        {
            try
            {
                clientSocket.Connect(IP, port);
            }
            catch (Exception) { }
        }

        private void sendBtn_Click(object sender, EventArgs e)
        {
            if (clientSocket.Connected == true)
            {
                byte[] outStream = Encoding.ASCII.GetBytes(chatTxt.Text + "$");
                serverStream.Write(outStream, 0, outStream.Length);
                serverStream.Flush();
                chatTxt.Text = "";
            } else
            {
                chatTxt.Hide();
                sendBtn.Hide();
                chatScreen.Text = "Disconnected to the server. Please try to sign in again.";
            }
        }

        private void getMessage()
        {
            bool flag = true;
            while (flag == true)
            {
                try
                {
                    serverStream = clientSocket.GetStream();
                    byte[] inStream = new byte[10025];
                    serverStream.Read(inStream, 0, 10000);
                    string returnData = Encoding.ASCII.GetString(inStream);
                    readData = "" + returnData;
                    message();
                }
                catch (Exception) { flag = false; }
            }
        }

        private void message()
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(message));
            }
            else
            {
                chatScreen.Text += Environment.NewLine + readData;
            }
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverStream != null)
            {
                serverStream.Close();
                clientSocket.Close();
            }
        }

        private async void reconnectBtn_Click(object sender, EventArgs e)
        { 
            await establishConnection();
        }

        private void chatTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                sendBtn_Click((object) sender, (EventArgs) e);
            }
        }
    }
}
