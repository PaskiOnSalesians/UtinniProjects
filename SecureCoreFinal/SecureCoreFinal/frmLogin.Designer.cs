﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnLogin = new System.Windows.Forms.Button();
            this.panelDiv2 = new System.Windows.Forms.Panel();
            this.panelDiv1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.picTogglePass = new System.Windows.Forms.PictureBox();
            this.picWelcome = new System.Windows.Forms.PictureBox();
            this.lblTitol = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.swTextboxUsername = new InCont.SWTextbox();
            this.swTextboxPasswd = new InCont.SWTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.picTogglePass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLogin.Location = new System.Drawing.Point(482, 278);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 28);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelDiv2
            // 
            this.panelDiv2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDiv2.Location = new System.Drawing.Point(340, 235);
            this.panelDiv2.Margin = new System.Windows.Forms.Padding(0);
            this.panelDiv2.Name = "panelDiv2";
            this.panelDiv2.Size = new System.Drawing.Size(225, 3);
            this.panelDiv2.TabIndex = 7;
            // 
            // panelDiv1
            // 
            this.panelDiv1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelDiv1.Location = new System.Drawing.Point(340, 184);
            this.panelDiv1.Margin = new System.Windows.Forms.Padding(0);
            this.panelDiv1.Name = "panelDiv1";
            this.panelDiv1.Size = new System.Drawing.Size(225, 3);
            this.panelDiv1.TabIndex = 8;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExit.Location = new System.Drawing.Point(340, 278);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 28);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picTogglePass
            // 
            this.picTogglePass.Image = global::SecureCoreFinal.Properties.Resources.togglepassword;
            this.picTogglePass.Location = new System.Drawing.Point(568, 214);
            this.picTogglePass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picTogglePass.Name = "picTogglePass";
            this.picTogglePass.Size = new System.Drawing.Size(22, 22);
            this.picTogglePass.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTogglePass.TabIndex = 9;
            this.picTogglePass.TabStop = false;
            this.picTogglePass.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTogglePass_MouseDown);
            this.picTogglePass.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picTogglePass_MouseUp);
            // 
            // picWelcome
            // 
            this.picWelcome.Image = global::SecureCoreFinal.Properties.Resources.xdd;
            this.picWelcome.Location = new System.Drawing.Point(17, 31);
            this.picWelcome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.picWelcome.Name = "picWelcome";
            this.picWelcome.Size = new System.Drawing.Size(304, 324);
            this.picWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWelcome.TabIndex = 11;
            this.picWelcome.TabStop = false;
            // 
            // lblTitol
            // 
            this.lblTitol.AutoSize = true;
            this.lblTitol.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitol.Location = new System.Drawing.Point(2, 7);
            this.lblTitol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitol.Name = "lblTitol";
            this.lblTitol.Size = new System.Drawing.Size(149, 31);
            this.lblTitol.TabIndex = 15;
            this.lblTitol.Text = "Utinni App";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lblTitol);
            this.panelTop.Location = new System.Drawing.Point(340, 31);
            this.panelTop.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(225, 45);
            this.panelTop.TabIndex = 1;
            this.panelTop.TabStop = true;
            // 
            // swTextboxUsername
            // 
            this.swTextboxUsername.BackColor = System.Drawing.Color.Azure;
            this.swTextboxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextboxUsername.CampBuit = false;
            this.swTextboxUsername.ClauForanea = false;
            this.swTextboxUsername.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextboxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.swTextboxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.swTextboxUsername.Location = new System.Drawing.Point(340, 161);
            this.swTextboxUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.swTextboxUsername.Name = "swTextboxUsername";
            this.swTextboxUsername.NomBBDD = "Login";
            this.swTextboxUsername.Size = new System.Drawing.Size(223, 23);
            this.swTextboxUsername.TabIndex = 2;
            this.swTextboxUsername.Text = "username";
            this.swTextboxUsername.Enter += new System.EventHandler(this.swTextboxUsername_Enter);
            // 
            // swTextboxPasswd
            // 
            this.swTextboxPasswd.BackColor = System.Drawing.Color.Azure;
            this.swTextboxPasswd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.swTextboxPasswd.CampBuit = false;
            this.swTextboxPasswd.ClauForanea = false;
            this.swTextboxPasswd.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextboxPasswd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.swTextboxPasswd.ForeColor = System.Drawing.Color.DimGray;
            this.swTextboxPasswd.Location = new System.Drawing.Point(340, 211);
            this.swTextboxPasswd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.swTextboxPasswd.Name = "swTextboxPasswd";
            this.swTextboxPasswd.NomBBDD = "Password";
            this.swTextboxPasswd.Size = new System.Drawing.Size(223, 23);
            this.swTextboxPasswd.TabIndex = 3;
            this.swTextboxPasswd.Text = "password";
            this.swTextboxPasswd.Enter += new System.EventHandler(this.swTextboxPasswd_Enter);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(604, 382);
            this.Controls.Add(this.swTextboxUsername);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelDiv1);
            this.Controls.Add(this.panelDiv2);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.picWelcome);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.swTextboxPasswd);
            this.Controls.Add(this.picTogglePass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLogin_FormClosing);
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTogglePass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Panel panelDiv2;
        private System.Windows.Forms.Panel panelDiv1;
        private System.Windows.Forms.PictureBox picTogglePass;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picWelcome;
        private System.Windows.Forms.Label lblTitol;
        private System.Windows.Forms.Panel panelTop;
        private InCont.SWTextbox swTextboxUsername;
        private InCont.SWTextbox swTextboxPasswd;
    }
}