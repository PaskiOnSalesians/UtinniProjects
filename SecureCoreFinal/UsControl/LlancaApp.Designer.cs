namespace UsControl
{
    partial class LlancaApp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLlenca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLlenca
            // 
            this.btnLlenca.BackColor = System.Drawing.Color.Peru;
            this.btnLlenca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLlenca.Location = new System.Drawing.Point(5, 5);
            this.btnLlenca.Margin = new System.Windows.Forms.Padding(5);
            this.btnLlenca.Name = "btnLlenca";
            this.btnLlenca.Size = new System.Drawing.Size(190, 60);
            this.btnLlenca.TabIndex = 0;
            this.btnLlenca.Text = "Llença";
            this.btnLlenca.UseVisualStyleBackColor = false;
            this.btnLlenca.Click += new System.EventHandler(this.btnLlenca_Click);
            // 
            // LlancaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLlenca);
            this.Name = "LlancaApp";
            this.Size = new System.Drawing.Size(200, 70);
            this.Load += new System.EventHandler(this.LlancaApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLlenca;
    }
}
