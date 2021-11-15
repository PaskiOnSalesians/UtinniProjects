
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
            this.lblTest = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.llancaApp1 = new UsControl.LlancaApp();
            this.panelTop.SuspendLayout();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTest
            // 
            this.lblTest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTest.AutoSize = true;
            this.lblTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.lblTest.Location = new System.Drawing.Point(954, 9);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(65, 36);
            this.lblTest.TabIndex = 0;
            this.lblTest.Text = "Exit";
            this.lblTest.Click += new System.EventHandler(this.lblTest_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTop.Controls.Add(this.lblTest);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.ForeColor = System.Drawing.Color.White;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1031, 55);
            this.panelTop.TabIndex = 1;
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.DarkBlue;
            this.panelLeft.Controls.Add(this.llancaApp1);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.ForeColor = System.Drawing.Color.White;
            this.panelLeft.Location = new System.Drawing.Point(0, 55);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(200, 492);
            this.panelLeft.TabIndex = 2;
            // 
            // llancaApp1
            // 
            this.llancaApp1.Classe = null;
            this.llancaApp1.Descripcio = "Hola";
            this.llancaApp1.Dock = System.Windows.Forms.DockStyle.Top;
            this.llancaApp1.Formulari = null;
            this.llancaApp1.Location = new System.Drawing.Point(0, 0);
            this.llancaApp1.Name = "llancaApp1";
            this.llancaApp1.Size = new System.Drawing.Size(200, 70);
            this.llancaApp1.TabIndex = 0;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(1031, 547);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Secure Core";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panelLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panelLeft;
        private UsControl.LlancaApp llancaApp1;
    }
}