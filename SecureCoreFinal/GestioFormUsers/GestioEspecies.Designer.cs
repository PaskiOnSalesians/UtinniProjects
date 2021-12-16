namespace GestioFormUsers
{
    partial class GestioEspecies
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
            this.swTextbox1 = new InCont.SWTextbox();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampBuit = true;
            this.swTextbox1.ClauForanea = false;
            this.swTextbox1.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox1.Location = new System.Drawing.Point(200, 93);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomBBDD = "descSpecie";
            this.swTextbox1.Size = new System.Drawing.Size(285, 26);
            this.swTextbox1.TabIndex = 8;
            // 
            // GestioEspecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 763);
            this.Controls.Add(this.swTextbox1);
            this.Name = "GestioEspecies";
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox1;
    }
}
