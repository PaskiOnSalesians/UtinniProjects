
namespace SecureCoreFinal
{
    partial class frmSplash
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
            this.components = new System.ComponentModel.Container();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            this.lblText = new System.Windows.Forms.Label();
            this.panelPgb1 = new System.Windows.Forms.Panel();
            this.picSpaceShip = new System.Windows.Forms.PictureBox();
            this.panelPgb2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceShip)).BeginInit();
            this.SuspendLayout();
            // 
            // timerSplash
            // 
            this.timerSplash.Enabled = true;
            this.timerSplash.Interval = 400;
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(44, 82);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(256, 46);
            this.lblText.TabIndex = 2;
            this.lblText.Text = "Secure Core";
            // 
            // panelPgb1
            // 
            this.panelPgb1.BackColor = System.Drawing.Color.Cyan;
            this.panelPgb1.Location = new System.Drawing.Point(70, 256);
            this.panelPgb1.Name = "panelPgb1";
            this.panelPgb1.Size = new System.Drawing.Size(12, 46);
            this.panelPgb1.TabIndex = 4;
            // 
            // picSpaceShip
            // 
            this.picSpaceShip.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picSpaceShip.Image = global::SecureCoreFinal.Properties.Resources.starwarshlaconlool2;
            this.picSpaceShip.Location = new System.Drawing.Point(74, 196);
            this.picSpaceShip.Name = "picSpaceShip";
            this.picSpaceShip.Size = new System.Drawing.Size(226, 187);
            this.picSpaceShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSpaceShip.TabIndex = 3;
            this.picSpaceShip.TabStop = false;
            // 
            // panelPgb2
            // 
            this.panelPgb2.BackColor = System.Drawing.Color.Cyan;
            this.panelPgb2.Location = new System.Drawing.Point(70, 297);
            this.panelPgb2.Name = "panelPgb2";
            this.panelPgb2.Size = new System.Drawing.Size(21, 34);
            this.panelPgb2.TabIndex = 5;
            // 
            // frmSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelPgb2);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.panelPgb1);
            this.Controls.Add(this.picSpaceShip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.picSpaceShip)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerSplash;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Panel panelPgb1;
        private System.Windows.Forms.PictureBox picSpaceShip;
        private System.Windows.Forms.Panel panelPgb2;
    }
}

