
namespace ConsoleForm
{
    partial class OpenConsole
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
            this.btn_console = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_console
            // 
            this.btn_console.BackColor = System.Drawing.Color.Black;
            this.btn_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_console.ForeColor = System.Drawing.Color.White;
            this.btn_console.Location = new System.Drawing.Point(121, 76);
            this.btn_console.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_console.Name = "btn_console";
            this.btn_console.Size = new System.Drawing.Size(558, 298);
            this.btn_console.TabIndex = 1;
            this.btn_console.Text = "Open Console";
            this.btn_console.UseVisualStyleBackColor = false;
            this.btn_console.Click += new System.EventHandler(this.btn_console_Click);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(738, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(41, 47);
            this.lblExit.TabIndex = 8;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // OpenConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btn_console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenConsole";
            this.Text = "OpenConsole";
            this.Load += new System.EventHandler(this.OpenConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_console;
        public System.Windows.Forms.Label lblExit;
    }
}