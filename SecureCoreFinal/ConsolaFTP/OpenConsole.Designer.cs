
namespace ConsolaFTP
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
            this.SuspendLayout();
            // 
            // btn_console
            // 
            this.btn_console.BackColor = System.Drawing.Color.Black;
            this.btn_console.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_console.ForeColor = System.Drawing.Color.White;
            this.btn_console.Location = new System.Drawing.Point(217, 144);
            this.btn_console.Name = "btn_console";
            this.btn_console.Size = new System.Drawing.Size(372, 194);
            this.btn_console.TabIndex = 0;
            this.btn_console.Text = "Open Console";
            this.btn_console.UseVisualStyleBackColor = false;
            this.btn_console.Click += new System.EventHandler(this.btn_console_Click);
            // 
            // OpenConsole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_console);
            this.Name = "OpenConsole";
            this.Text = "OpenConsole";
            this.Load += new System.EventHandler(this.OpenConsole_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_console;
    }
}