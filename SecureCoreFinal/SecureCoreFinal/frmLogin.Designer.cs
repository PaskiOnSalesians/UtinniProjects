
namespace SecureCoreFinal
{
    partial class frmLogin
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
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelDiv2 = new System.Windows.Forms.Panel();
            this.panelDiv1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.picTogglePass = new System.Windows.Forms.PictureBox();
            this.picWelcome = new System.Windows.Forms.PictureBox();
            this.lblTitol = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picTogglePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Azure;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtUsername.ForeColor = System.Drawing.Color.DimGray;
            this.txtUsername.Location = new System.Drawing.Point(454, 197);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(299, 29);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "username";
            this.txtUsername.Enter += new System.EventHandler(this.txtUsername_Enter);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Azure;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txtPassword.ForeColor = System.Drawing.Color.DimGray;
            this.txtPassword.Location = new System.Drawing.Point(454, 259);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(267, 29);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.Text = "password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(642, 342);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(112, 34);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelDiv2
            // 
            this.panelDiv2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDiv2.Location = new System.Drawing.Point(454, 289);
            this.panelDiv2.Margin = new System.Windows.Forms.Padding(0);
            this.panelDiv2.Name = "panelDiv2";
            this.panelDiv2.Size = new System.Drawing.Size(300, 4);
            this.panelDiv2.TabIndex = 7;
            // 
            // panelDiv1
            // 
            this.panelDiv1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDiv1.Location = new System.Drawing.Point(454, 227);
            this.panelDiv1.Margin = new System.Windows.Forms.Padding(0);
            this.panelDiv1.Name = "panelDiv1";
            this.panelDiv1.Size = new System.Drawing.Size(300, 4);
            this.panelDiv1.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(454, 342);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(112, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picTogglePass
            // 
            this.picTogglePass.Image = global::SecureCoreFinal.Properties.Resources.togglepassword;
            this.picTogglePass.Location = new System.Drawing.Point(724, 259);
            this.picTogglePass.Name = "picTogglePass";
            this.picTogglePass.Size = new System.Drawing.Size(29, 27);
            this.picTogglePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTogglePass.TabIndex = 9;
            this.picTogglePass.TabStop = false;
            this.picTogglePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTogglePass_MouseDown);
            this.picTogglePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTogglePass_MouseUp);
            // 
            // picWelcome
            // 
            this.picWelcome.Image = global::SecureCoreFinal.Properties.Resources.xdd;
            this.picWelcome.Location = new System.Drawing.Point(23, 38);
            this.picWelcome.Name = "picWelcome";
            this.picWelcome.Size = new System.Drawing.Size(405, 399);
            this.picWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWelcome.TabIndex = 11;
            this.picWelcome.TabStop = false;
            // 
            // lblTitol
            // 
            this.lblTitol.AutoSize = true;
            this.lblTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitol.Location = new System.Drawing.Point(3, 9);
            this.lblTitol.Name = "lblTitol";
            this.lblTitol.Size = new System.Drawing.Size(177, 38);
            this.lblTitol.TabIndex = 15;
            this.lblTitol.Text = "Utinni App";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitol);
            this.panelTop.Location = new System.Drawing.Point(454, 38);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(300, 55);
            this.panelTop.TabIndex = 1;
            this.panelTop.TabStop = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(806, 470);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picTogglePass);
            this.Controls.Add(this.panelDiv1);
            this.Controls.Add(this.panelDiv2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.picWelcome);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.picTogglePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelDiv2;
        private System.Windows.Forms.Panel panelDiv1;
        private System.Windows.Forms.PictureBox picTogglePass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picWelcome;
        private System.Windows.Forms.Label lblTitol;
        private System.Windows.Forms.Panel panelTop;
    }
}