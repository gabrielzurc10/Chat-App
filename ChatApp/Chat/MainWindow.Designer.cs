namespace Chat
{
    partial class MainWindow
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.fullnameTxt = new System.Windows.Forms.Label();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.reconnectBtn = new System.Windows.Forms.Button();
            this.signOutBtn = new System.Windows.Forms.Button();
            this.sendBtn = new System.Windows.Forms.Button();
            this.chatTxt = new System.Windows.Forms.TextBox();
            this.chatScreen = new System.Windows.Forms.TextBox();
            this.loadingImg = new System.Windows.Forms.PictureBox();
            this.topPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImg)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.topPanel.Controls.Add(this.fullnameTxt);
            this.topPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(746, 34);
            this.topPanel.TabIndex = 19;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            // 
            // fullnameTxt
            // 
            this.fullnameTxt.AutoSize = true;
            this.fullnameTxt.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnameTxt.ForeColor = System.Drawing.Color.White;
            this.fullnameTxt.Location = new System.Drawing.Point(12, 6);
            this.fullnameTxt.Name = "fullnameTxt";
            this.fullnameTxt.Size = new System.Drawing.Size(92, 21);
            this.fullnameTxt.TabIndex = 0;
            this.fullnameTxt.Text = "Placeholder";
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(41)))));
            this.minimizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(746, 0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(37, 34);
            this.minimizeBtn.TabIndex = 17;
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
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(783, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(37, 34);
            this.closeBtn.TabIndex = 18;
            this.closeBtn.TabStop = false;
            this.closeBtn.Text = "X";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.closeBtn_MouseClick);
            // 
            // bottomPanel
            // 
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.bottomPanel.Controls.Add(this.reconnectBtn);
            this.bottomPanel.Controls.Add(this.signOutBtn);
            this.bottomPanel.Controls.Add(this.sendBtn);
            this.bottomPanel.Controls.Add(this.chatTxt);
            this.bottomPanel.Location = new System.Drawing.Point(0, 600);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(820, 34);
            this.bottomPanel.TabIndex = 21;
            // 
            // reconnectBtn
            // 
            this.reconnectBtn.BackColor = System.Drawing.Color.SpringGreen;
            this.reconnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reconnectBtn.FlatAppearance.BorderSize = 0;
            this.reconnectBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSeaGreen;
            this.reconnectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.reconnectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reconnectBtn.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reconnectBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reconnectBtn.Location = new System.Drawing.Point(471, 0);
            this.reconnectBtn.Name = "reconnectBtn";
            this.reconnectBtn.Size = new System.Drawing.Size(109, 35);
            this.reconnectBtn.TabIndex = 2;
            this.reconnectBtn.Text = "Reconnect";
            this.reconnectBtn.UseVisualStyleBackColor = false;
            this.reconnectBtn.Visible = false;
            this.reconnectBtn.Click += new System.EventHandler(this.reconnectBtn_Click);
            // 
            // signOutBtn
            // 
            this.signOutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOutBtn.FlatAppearance.BorderSize = 0;
            this.signOutBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.signOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.signOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signOutBtn.Font = new System.Drawing.Font("Corbel", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signOutBtn.ForeColor = System.Drawing.Color.Silver;
            this.signOutBtn.Location = new System.Drawing.Point(60, 0);
            this.signOutBtn.Name = "signOutBtn";
            this.signOutBtn.Size = new System.Drawing.Size(117, 34);
            this.signOutBtn.TabIndex = 0;
            this.signOutBtn.Text = "SIGN OUT";
            this.signOutBtn.UseVisualStyleBackColor = true;
            this.signOutBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // sendBtn
            // 
            this.sendBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.sendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendBtn.FlatAppearance.BorderSize = 0;
            this.sendBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.sendBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.sendBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendBtn.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sendBtn.Location = new System.Drawing.Point(711, 1);
            this.sendBtn.Name = "sendBtn";
            this.sendBtn.Size = new System.Drawing.Size(109, 34);
            this.sendBtn.TabIndex = 1;
            this.sendBtn.Text = "SEND";
            this.sendBtn.UseVisualStyleBackColor = false;
            this.sendBtn.Visible = false;
            this.sendBtn.Click += new System.EventHandler(this.sendBtn_Click);
            // 
            // chatTxt
            // 
            this.chatTxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.chatTxt.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatTxt.Location = new System.Drawing.Point(391, 5);
            this.chatTxt.Multiline = true;
            this.chatTxt.Name = "chatTxt";
            this.chatTxt.Size = new System.Drawing.Size(280, 22);
            this.chatTxt.TabIndex = 0;
            this.chatTxt.Visible = false;
            this.chatTxt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatTxt_KeyDown);
            // 
            // chatScreen
            // 
            this.chatScreen.BackColor = System.Drawing.Color.White;
            this.chatScreen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatScreen.Font = new System.Drawing.Font("Corbel", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatScreen.Location = new System.Drawing.Point(0, 40);
            this.chatScreen.Multiline = true;
            this.chatScreen.Name = "chatScreen";
            this.chatScreen.ReadOnly = true;
            this.chatScreen.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.chatScreen.Size = new System.Drawing.Size(820, 554);
            this.chatScreen.TabIndex = 22;
            // 
            // loadingImg
            // 
            this.loadingImg.BackColor = System.Drawing.Color.White;
            this.loadingImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.loadingImg.Image = global::Chat.Properties.Resources.Ripple_1s_200px;
            this.loadingImg.Location = new System.Drawing.Point(326, 238);
            this.loadingImg.Name = "loadingImg";
            this.loadingImg.Size = new System.Drawing.Size(169, 159);
            this.loadingImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingImg.TabIndex = 6;
            this.loadingImg.TabStop = false;
            this.loadingImg.Visible = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(820, 634);
            this.Controls.Add(this.loadingImg);
            this.Controls.Add(this.bottomPanel);
            this.Controls.Add(this.chatScreen);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.closeBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Button sendBtn;
        private System.Windows.Forms.TextBox chatTxt;
        private System.Windows.Forms.Button signOutBtn;
        private System.Windows.Forms.TextBox chatScreen;
        private System.Windows.Forms.Label fullnameTxt;
        private System.Windows.Forms.Button reconnectBtn;
        private System.Windows.Forms.PictureBox loadingImg;
    }
}