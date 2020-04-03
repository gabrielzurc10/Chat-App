using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Chat
{
    public partial class CreateAccount : Form
    {
        Point PanelMouseDownLocation;
        LoginForm loginForm = new LoginForm();
        StringFormatter stringFormat = new StringFormatter();
        DataAccess dataAccess = new DataAccess();

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            
        }

        private void minimizeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void backBtn_MouseClick(object sender, MouseEventArgs e)
        {
            loginForm.Show();
            this.Hide();
        }

        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                PanelMouseDownLocation = e.Location;
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - PanelMouseDownLocation.X;
                this.Top += e.Y - PanelMouseDownLocation.Y;
            }
        }

        private async void createBtn_Click(object sender, EventArgs e)
        {
            loadingImg.Show();
            await ProcessCreateAccount();        
        }

        public async Task ProcessCreateAccount()
        {
            
            int result = 6;
            try
            {
                if (firstNameTxt.Text == "")
                {
                    invalidNameLbl.Show();
                    result += 1;
                }
                else { invalidNameLbl.Hide(); result -= 1; }
                if (lastNameTxt.Text == "")
                {
                    invalidLastNameLbl.Show();
                    result += 1;
                }
                else { invalidLastNameLbl.Hide(); result -= 1; }
                if (dataAccess.IfDataExist(userNameTxt.Text) == true || userNameTxt.Text == "")
                {
                    invalidUserNameLbl.Show();
                    result += 1;
                }
                else { invalidUserNameLbl.Hide(); result -= 1; }
                if (dataAccess.IfDataExist(passwordTxt.Text) == true || passwordTxt.Text == "")
                {
                    invalidPasswordLbl.Show();
                    result += 1;
                }
                else { invalidPasswordLbl.Hide(); result -= 1; }
                if (dataAccess.IfDataExist(emailTxt.Text) == true || emailTxt.Text == "" || stringFormat.IsEmailValid(emailTxt.Text) == false)
                {
                    invalidEmailLbl.Show();
                    result += 1;
                }
                else { invalidEmailLbl.Hide(); result -= 1; }
                if (dataAccess.IfDataExist(phoneNumberTxt.Text) == true || phoneNumberTxt.Text == "")
                {
                    invalidPhoneNumberLbl.Show();
                    result += 1;
                }
                else { invalidPhoneNumberLbl.Hide(); result -= 1; }
                if (result == 0)
                {
                    createBtn.Enabled = false;
                    createBtn.Text = "CREATING ACCOUNT";
                    await Task.Run(() => dataAccess.CreateAccount(firstNameTxt.Text, lastNameTxt.Text, userNameTxt.Text, passwordTxt.Text, emailTxt.Text, phoneNumberTxt.Text));
                    MessageBox.Show("Account Successfully Created", "Success");
                    loginForm.Show();
                    this.Hide();
                }
            }
            catch (Exception e)
            {               
                MessageBox.Show("Invalid");
            }
            loadingImg.Hide();
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            firstNameTxt.Text = stringFormat.NameFormat(firstNameTxt.Text);
            lastNameTxt.Text = stringFormat.NameFormat(lastNameTxt.Text);
            userNameTxt.Text = userNameTxt.Text.Replace(" ","");
            emailTxt.Text = emailTxt.Text.Replace(" ", "");    
               if (phoneNumberTxt.TextLength == 10)
            {
                phoneNumberTxt.Text = stringFormat.PhoneNumberFormat(phoneNumberTxt.Text);
            }
            else if (phoneNumberTxt.TextLength < 14)
            {
                phoneNumberTxt.Text = "";
            }
        }

        private void phoneNumberTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void firstNameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
