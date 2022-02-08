
namespace GestioFTP
{
    partial class Frm_OpenConsole
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
            this.lbl_close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_console
            // 
            this.btn_console.BackColor = System.Drawing.Color.Black;
            this.btn_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_console.ForeColor = System.Drawing.Color.White;
            this.btn_console.Location = new System.Drawing.Point(226, 143);
            this.btn_console.Name = "btn_console";
            this.btn_console.Size = new System.Drawing.Size(341, 189);
            this.btn_console.TabIndex = 0;
            this.btn_console.Text = "Open Console";
            this.btn_console.UseVisualStyleBackColor = false;
            this.btn_console.Click += new System.EventHandler(this.btn_console_Click);
            // 
            // lbl_close
            // 
            this.lbl_close.AutoSize = true;
            this.lbl_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_close.Location = new System.Drawing.Point(755, 9);
            this.lbl_close.Name = "lbl_close";
            this.lbl_close.Size = new System.Drawing.Size(33, 31);
            this.lbl_close.TabIndex = 1;
            this.lbl_close.Text = "X";
            this.lbl_close.Click += new System.EventHandler(this.lbl_close_Click);
            // 
            // Frm_OpenConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_close);
            this.Controls.Add(this.btn_console);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_OpenConsole";
            this.Text = "Frm_OpenConsole";
            this.Load += new System.EventHandler(this.Frm_OpenConsole_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_console;
        private System.Windows.Forms.Label lbl_close;
    }
}