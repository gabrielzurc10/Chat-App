namespace Chat
{
    partial class CreateAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstNameTxt = new System.Windows.Forms.TextBox();
            this.lastNameTxt = new System.Windows.Forms.TextBox();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.emailTxt = new System.Windows.Forms.TextBox();
            this.phoneNumberTxt = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.firstNameLbl = new System.Windows.Forms.Label();
            this.lastNameLbl = new System.Windows.Forms.Label();
            this.userNameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.emailLbl = new System.Windows.Forms.Label();
            this.phoneNumberLbl = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.topPanel = new System.Windows.Forms.Panel();
            this.loadingImg = new System.Windows.Forms.PictureBox();
            this.invalidFirstNameLbl = new System.Windows.Forms.Label();
            this.invalidUserNameLbl = new System.Windows.Forms.Label();
            this.invalidPasswordLbl = new System.Windows.Forms.Label();
            this.invalidEmailLbl = new System.Windows.Forms.Label();
            this.invalidPhoneNumberLbl = new System.Windows.Forms.Label();
            this.invalidNameLbl = new System.Windows.Forms.Label();
            this.invalidLastNameLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameTxt
            // 
            this.firstNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.firstNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.firstNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.firstNameTxt.Location = new System.Drawing.Point(283, 122);
            this.firstNameTxt.MaxLength = 30;
            this.firstNameTxt.Name = "firstNameTxt";
            this.firstNameTxt.Size = new System.Drawing.Size(255, 27);
            this.firstNameTxt.TabIndex = 0;
            this.firstNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTxt_KeyPress);
            this.firstNameTxt.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // lastNameTxt
            // 
            this.lastNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.lastNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lastNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lastNameTxt.Location = new System.Drawing.Point(283, 168);
            this.lastNameTxt.MaxLength = 30;
            this.lastNameTxt.Name = "lastNameTxt";
            this.lastNameTxt.Size = new System.Drawing.Size(255, 27);
            this.lastNameTxt.TabIndex = 1;
            this.lastNameTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.firstNameTxt_KeyPress);
            this.lastNameTxt.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.userNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.userNameTxt.Location = new System.Drawing.Point(283, 209);
            this.userNameTxt.MaxLength = 16;
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(255, 27);
            this.userNameTxt.TabIndex = 2;
            this.userNameTxt.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.SystemColors.Control;
            this.passwordTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.passwordTxt.Location = new System.Drawing.Point(283, 252);
            this.passwordTxt.MaxLength = 16;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(255, 27);
            this.passwordTxt.TabIndex = 3;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // emailTxt
            // 
            this.emailTxt.BackColor = System.Drawing.SystemColors.Control;
            this.emailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.emailTxt.Location = new System.Drawing.Point(283, 293);
            this.emailTxt.MaxLength = 30;
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(255, 27);
            this.emailTxt.TabIndex = 4;
            this.emailTxt.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // phoneNumberTxt
            // 
            this.phoneNumberTxt.BackColor = System.Drawing.SystemColors.Control;
            this.phoneNumberTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneNumberTxt.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.phoneNumberTxt.Location = new System.Drawing.Point(283, 333);
            this.phoneNumberTxt.MaxLength = 10;
            this.phoneNumberTxt.Name = "phoneNumberTxt";
            this.phoneNumberTxt.Size = new System.Drawing.Size(255, 27);
            this.phoneNumberTxt.TabIndex = 5;
            this.phoneNumberTxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phoneNumberTxt_KeyPress);
            this.phoneNumberTxt.Leave += new System.EventHandler(this.textBox_Leave);
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.createBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.DimGray;
            this.createBtn.Location = new System.Drawing.Point(283, 386);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(255, 31);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "SIGN UP";
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backBtn.FlatAppearance.BorderSize = 0;
            this.backBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.backBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.DimGray;
            this.backBtn.Location = new System.Drawing.Point(293, 597);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(235, 34);
            this.backBtn.TabIndex = 7;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.backBtn_MouseClick);
            // 
            // firstNameLbl
            // 
            this.firstNameLbl.AutoSize = true;
            this.firstNameLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.firstNameLbl.Location = new System.Drawing.Point(179, 122);
            this.firstNameLbl.Name = "firstNameLbl";
            this.firstNameLbl.Size = new System.Drawing.Size(92, 23);
            this.firstNameLbl.TabIndex = 8;
            this.firstNameLbl.Text = "First Name";
            // 
            // lastNameLbl
            // 
            this.lastNameLbl.AutoSize = true;
            this.lastNameLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.lastNameLbl.Location = new System.Drawing.Point(183, 169);
            this.lastNameLbl.Name = "lastNameLbl";
            this.lastNameLbl.Size = new System.Drawing.Size(91, 23);
            this.lastNameLbl.TabIndex = 9;
            this.lastNameLbl.Text = "Last Name";
            // 
            // userNameLbl
            // 
            this.userNameLbl.AutoSize = true;
            this.userNameLbl.BackColor = System.Drawing.Color.Transparent;
            this.userNameLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameLbl.ForeColor = System.Drawing.Color.DimGray;
            this.userNameLbl.Location = new System.Drawing.Point(188, 210);
            this.userNameLbl.Name = "userNameLbl";
            this.userNameLbl.Size = new System.Drawing.Size(87, 23);
            this.userNameLbl.TabIndex = 10;
            this.userNameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.DimGray;
            this.passwordLbl.Location = new System.Drawing.Point(191, 253);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(80, 23);
            this.passwordLbl.TabIndex = 11;
            this.passwordLbl.Text = "Password";
            // 
            // emailLbl
            // 
            this.emailLbl.AutoSize = true;
            this.emailLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLbl.ForeColor = System.Drawing.Color.DimGray;
            this.emailLbl.Location = new System.Drawing.Point(223, 294);
            this.emailLbl.Name = "emailLbl";
            this.emailLbl.Size = new System.Drawing.Size(51, 23);
            this.emailLbl.TabIndex = 12;
            this.emailLbl.Text = "Email";
            // 
            // phoneNumberLbl
            // 
            this.phoneNumberLbl.AutoSize = true;
            this.phoneNumberLbl.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneNumberLbl.ForeColor = System.Drawing.Color.DimGray;
            this.phoneNumberLbl.Location = new System.Drawing.Point(148, 334);
            this.phoneNumberLbl.Name = "phoneNumberLbl";
            this.phoneNumberLbl.Size = new System.Drawing.Size(127, 23);
            this.phoneNumberLbl.TabIndex = 13;
            this.phoneNumberLbl.Text = "Phone Number";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(746, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(37, 34);
            this.minimizeBtn.TabIndex = 14;
            this.minimizeBtn.TabStop = false;
            this.minimizeBtn.Text = "__";
            this.minimizeBtn.UseVisualStyleBackColor = false;
            this.minimizeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.minimizeBtn_MouseClick);
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(783, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 34);
            this.closeBtn.TabIndex = 15;
            this.closeBtn.TabStop = false;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.topPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(746, 34);
            this.topPanel.TabIndex = 16;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // loadingImg
            // 
            this.loadingImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadingImg.Image = global::Chat.Properties.Resources.Ripple_1s_200px;
            this.loadingImg.Location = new System.Drawing.Point(326, 429);
            this.loadingImg.Name = "loadingImg";
            this.loadingImg.Size = new System.Drawing.Size(169, 159);
            this.loadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingImg.TabIndex = 17;
            this.loadingImg.TabStop = false;
            this.loadingImg.Visible = false;
            // 
            // invalidFirstNameLbl
            // 
            this.invalidFirstNameLbl.AutoSize = true;
            this.invalidFirstNameLbl.Location = new System.Drawing.Point(544, 127);
            this.invalidFirstNameLbl.Name = "invalidFirstNameLbl";
            this.invalidFirstNameLbl.Size = new System.Drawing.Size(0, 17);
            this.invalidFirstNameLbl.TabIndex = 18;
            // 
            // invalidUserNameLbl
            // 
            this.invalidUserNameLbl.AutoSize = true;
            this.invalidUserNameLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidUserNameLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.invalidUserNameLbl.Location = new System.Drawing.Point(544, 215);
            this.invalidUserNameLbl.Name = "invalidUserNameLbl";
            this.invalidUserNameLbl.Size = new System.Drawing.Size(228, 20);
            this.invalidUserNameLbl.TabIndex = 20;
            this.invalidUserNameLbl.Text = "Invalid Username / Already Exists";
            this.invalidUserNameLbl.Visible = false;
            // 
            // invalidPasswordLbl
            // 
            this.invalidPasswordLbl.AutoSize = true;
            this.invalidPasswordLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidPasswordLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.invalidPasswordLbl.Location = new System.Drawing.Point(544, 258);
            this.invalidPasswordLbl.Name = "invalidPasswordLbl";
            this.invalidPasswordLbl.Size = new System.Drawing.Size(225, 20);
            this.invalidPasswordLbl.TabIndex = 21;
            this.invalidPasswordLbl.Text = "Invalid password / Already Exists";
            this.invalidPasswordLbl.Visible = false;
            // 
            // invalidEmailLbl
            // 
            this.invalidEmailLbl.AutoSize = true;
            this.invalidEmailLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidEmailLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.invalidEmailLbl.Location = new System.Drawing.Point(544, 299);
            this.invalidEmailLbl.Name = "invalidEmailLbl";
            this.invalidEmailLbl.Size = new System.Drawing.Size(199, 20);
            this.invalidEmailLbl.TabIndex = 22;
            this.invalidEmailLbl.Text = "Invalid Email / Already Exists";
            this.invalidEmailLbl.Visible = false;
            // 
            // invalidPhoneNumberLbl
            // 
            this.invalidPhoneNumberLbl.AutoSize = true;
            this.invalidPhoneNumberLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidPhoneNumberLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.invalidPhoneNumberLbl.Location = new System.Drawing.Point(544, 339);
            this.invalidPhoneNumberLbl.Name = "invalidPhoneNumberLbl";
            this.invalidPhoneNumberLbl.Size = new System.Drawing.Size(261, 20);
            this.invalidPhoneNumberLbl.TabIndex = 23;
            this.invalidPhoneNumberLbl.Text = "Invalid Phone Number / Already Exists";
            this.invalidPhoneNumberLbl.Visible = false;
            // 
            // invalidNameLbl
            // 
            this.invalidNameLbl.AutoSize = true;
            this.invalidNameLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidNameLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.invalidNameLbl.Location = new System.Drawing.Point(544, 124);
            this.invalidNameLbl.Name = "invalidNameLbl";
            this.invalidNameLbl.Size = new System.Drawing.Size(128, 20);
            this.invalidNameLbl.TabIndex = 24;
            this.invalidNameLbl.Text = "Invalid First Name";
            this.invalidNameLbl.Visible = false;
            // 
            // invalidLastNameLbl
            // 
            this.invalidLastNameLbl.AutoSize = true;
            this.invalidLastNameLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invalidLastNameLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.invalidLastNameLbl.Location = new System.Drawing.Point(544, 171);
            this.invalidLastNameLbl.Name = "invalidLastNameLbl";
            this.invalidLastNameLbl.Size = new System.Drawing.Size(127, 20);
            this.invalidLastNameLbl.TabIndex = 25;
            this.invalidLastNameLbl.Text = "Invalid Last Name";
            this.invalidLastNameLbl.Visible = false;
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 634);
            this.Controls.Add(this.invalidLastNameLbl);
            this.Controls.Add(this.invalidNameLbl);
            this.Controls.Add(this.invalidPhoneNumberLbl);
            this.Controls.Add(this.invalidEmailLbl);
            this.Controls.Add(this.invalidPasswordLbl);
            this.Controls.Add(this.invalidUserNameLbl);
            this.Controls.Add(this.invalidFirstNameLbl);
            this.Controls.Add(this.loadingImg);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.phoneNumberLbl);
            this.Controls.Add(this.emailLbl);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.userNameLbl);
            this.Controls.Add(this.lastNameLbl);
            this.Controls.Add(this.firstNameLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.phoneNumberTxt);
            this.Controls.Add(this.emailTxt);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.lastNameTxt);
            this.Controls.Add(this.firstNameTxt);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateAccount";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chat - Create Account";
            this.Load += new System.EventHandler(this.CreateAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loadingImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameTxt;
        private System.Windows.Forms.TextBox lastNameTxt;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox emailTxt;
        private System.Windows.Forms.TextBox phoneNumberTxt;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label firstNameLbl;
        private System.Windows.Forms.Label lastNameLbl;
        private System.Windows.Forms.Label userNameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Label emailLbl;
        private System.Windows.Forms.Label phoneNumberLbl;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.PictureBox loadingImg;
        private System.Windows.Forms.Label invalidFirstNameLbl;
        private System.Windows.Forms.Label invalidUserNameLbl;
        private System.Windows.Forms.Label invalidPasswordLbl;
        private System.Windows.Forms.Label invalidEmailLbl;
        private System.Windows.Forms.Label invalidPhoneNumberLbl;
        private System.Windows.Forms.Label invalidNameLbl;
        private System.Windows.Forms.Label invalidLastNameLbl;
    }
}