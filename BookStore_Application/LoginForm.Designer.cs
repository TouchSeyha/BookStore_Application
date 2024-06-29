namespace BookStore_Application
{
    partial class LoginForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(52)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 94);
            this.panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Image = global::BookStore_Application.Properties.Resources.icons8_close_60;
            this.pictureBox1.Location = new System.Drawing.Point(772, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Khmer Victorya Jrung", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(254, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 108);
            this.label4.TabIndex = 0;
            this.label4.Text = "WELCOME";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(809, 575);
            this.panel3.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(809, 575);
            this.panel4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtUsername);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(809, 575);
            this.panel2.TabIndex = 11;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(345, 278);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(323, 1);
            this.panel6.TabIndex = 14;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(345, 214);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(323, 1);
            this.panel5.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(338, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 39);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOGIN";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.txtPassword.ForeColor = System.Drawing.Color.Gray;
            this.txtPassword.Location = new System.Drawing.Point(345, 248);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(325, 26);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.Text = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = global::BookStore_Application.Properties.Resources.icons8_key_48;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.label3.Location = new System.Drawing.Point(135, 237);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 53);
            this.label3.TabIndex = 8;
            this.label3.Text = "        Password : ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.FlatAppearance.BorderSize = 2;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Modern No. 20", 20F);
            this.btnLogin.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.Location = new System.Drawing.Point(185, 339);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(438, 67);
            this.btnLogin.TabIndex = 9;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Image = global::BookStore_Application.Properties.Resources.icons8_male_user_48;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(129, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 53);
            this.label2.TabIndex = 7;
            this.label2.Text = "        Username : ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoCompleteCustomSource.AddRange(new string[] {
            "Seyha"});
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F);
            this.txtUsername.ForeColor = System.Drawing.Color.Gray;
            this.txtUsername.Location = new System.Drawing.Point(345, 184);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(1);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(325, 26);
            this.txtUsername.TabIndex = 5;
            this.txtUsername.Text = "Enter Username";
            this.txtUsername.Click += new System.EventHandler(this.txtUsername_Click_1);
            this.txtUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(809, 669);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(809, 669);
            this.MinimumSize = new System.Drawing.Size(809, 669);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}