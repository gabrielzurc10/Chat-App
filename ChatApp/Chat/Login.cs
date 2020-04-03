using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chat
{
    
    public partial class LoginForm : Form
    {
        Point PanelMouseDownLocation;
        public static string fullName;
        public static string firstName;
        public static string userID;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Remember)
            {
                userNameTxt.Text = Properties.Settings.Default.UserName;
                passwordTxt.Text = Properties.Settings.Default.Password;
                rememberCbx.Checked = Properties.Settings.Default.Remember;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            loadingImg.Show();
            loginBtn.Text = "SIGNING IN";
            loginBtn.Enabled = false;
            invalidLbl.Visible = false;
            await ProcessLogin();
        }

        public async Task ProcessLogin()
        {
            var loginInfo = new List<string>();
            DataAccess dataAccess = new DataAccess();
            loginInfo = await Task.Run(() =>dataAccess.getLoginAuthentication(userNameTxt.Text, passwordTxt.Text));
            try
            {
                if (userNameTxt.Text == loginInfo[3] && passwordTxt.Text == loginInfo[4])
                {
                    
                    fullName = loginInfo[1] + " " + loginInfo[2];
                    firstName = loginInfo[1];
                    userID = loginInfo[0];

                    MainWindow mainWindow = new MainWindow();
                    SaveLoginState();
                    mainWindow.Show();
                    loadingImg.Hide();
                    this.Hide();
                }
            }
            catch (Exception)
            {
                loadingImg.Hide();
                loginBtn.Text = "SIGN IN";
                loginBtn.Enabled = true;
                invalidLbl.Visible = true;
            }
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

        private void createBtn_MouseClick(object sender, MouseEventArgs e)
        {
            CreateAccount createForm = new CreateAccount();
            Console.WriteLine("Hello");
            SaveLoginState();
            createForm.Show();
            this.Hide();
        }

        private void rememberCbx_CheckedChanged(object sender, EventArgs e)
        {
            SaveLoginState();
        }

        public void SaveLoginState()
        {
            if (rememberCbx.Checked == true)
            {
                Properties.Settings.Default.Remember = rememberCbx.Checked;
                Properties.Settings.Default.UserName = userNameTxt.Text;
                Properties.Settings.Default.Password = passwordTxt.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.Remember = rememberCbx.Checked;
                Properties.Settings.Default.UserName = userNameTxt.Text;
                Properties.Settings.Default.Password = passwordTxt.Text;
                Properties.Settings.Default.Save();
            }
            
        }

        private void passwordTxt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click((object)sender, (EventArgs)e);
            }
        }
    }
}
