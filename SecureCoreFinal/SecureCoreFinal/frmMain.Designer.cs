
namespace SecureCoreFinal
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblTest = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblAccessLevel = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.pnlMid = new System.Windows.Forms.Panel();
            this.pnlMidRight = new System.Windows.Forms.Panel();
            this.pnlMidBottom = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.pnlMid.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblTest.Location = new System.Drawing.Point(987, 9);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(32, 31);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "X";
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTop.Controls.Add(this.lblUsername);
            this.panelTop.Controls.Add(this.lblAccessLevel);
            this.panelTop.Controls.Add(this.lblTest);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1031, 55);
            this.panelTop.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblUsername.Location = new System.Drawing.Point(12, 15);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblAccessLevel
            // 
            this.lblAccessLevel.AutoSize = true;
            this.lblAccessLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblAccessLevel.Location = new System.Drawing.Point(199, 16);
            this.lblAccessLevel.Name = "lblAccessLevel";
            this.lblAccessLevel.Size = new System.Drawing.Size(154, 29);
            this.lblAccessLevel.TabIndex = 1;
            this.lblAccessLevel.Text = "Access Level";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkBlue;
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(0, 55);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 491);
            this.panelLeft.TabIndex = 2;
            // 
            // pnlMid
            // 
            this.pnlMid.Controls.Add(this.pnlMidRight);
            this.pnlMid.Controls.Add(this.pnlMidBottom);
            this.pnlMid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMid.Location = new System.Drawing.Point(200, 55);
            this.pnlMid.Name = "pnlMid";
            this.pnlMid.Size = new System.Drawing.Size(831, 491);
            this.pnlMid.TabIndex = 3;
            // 
            // pnlMidRight
            // 
            this.pnlMidRight.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMidRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMidRight.Location = new System.Drawing.Point(812, 0);
            this.pnlMidRight.Name = "pnlMidRight";
            this.pnlMidRight.Size = new System.Drawing.Size(19, 476);
            this.pnlMidRight.TabIndex = 1;
            // 
            // pnlMidBottom
            // 
            this.pnlMidBottom.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlMidBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlMidBottom.Location = new System.Drawing.Point(0, 476);
            this.pnlMidBottom.Name = "pnlMidBottom";
            this.pnlMidBottom.Size = new System.Drawing.Size(831, 15);
            this.pnlMidBottom.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1031, 546);
            this.Controls.Add(this.pnlMid);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.pnlMid.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label lblAccessLevel;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlMid;
        private System.Windows.Forms.Panel pnlMidRight;
        private System.Windows.Forms.Panel pnlMidBottom;
    }
}