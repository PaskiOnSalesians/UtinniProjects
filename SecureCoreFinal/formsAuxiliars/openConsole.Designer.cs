
namespace formsAuxiliars
{
    partial class openConsole
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
            this.lbl_close = new System.Windows.Forms.Label();
            this.btn_console = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(749, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(39, 37);
            this.lbl_close.TabIndex = 0;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // btn_console
            // 
            this.btn_console.BackColor = System.Drawing.Color.Black;
            this.btn_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_console.ForeColor = System.Drawing.Color.White;
            this.btn_console.Location = new System.Drawing.Point(195, 131);
            this.btn_console.Name = "btn_console";
            this.btn_console.Size = new System.Drawing.Size(380, 197);
            this.btn_console.TabIndex = 1;
            this.btn_console.Text = "Open Console";
            this.btn_console.UseVisualStyleBackColor = false;
            this.btn_console.Click += new System.EventHandler(this.btn_console_Click);
            // 
            // openConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_console);
            this.Controls.Add(this.lbl_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "openConsole";
            this.Text = "openConsole";
            this.Load += new System.EventHandler(this.openConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_close;
        private System.Windows.Forms.Button btn_console;
    }
}