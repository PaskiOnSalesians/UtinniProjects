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
            this.swTextbox2 = new InCont.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampBuit = true;
            this.swTextbox1.ClauForanea = false;
            this.swTextbox1.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox1.Location = new System.Drawing.Point(309, 122);
            this.swTextbox1.Margin = new System.Windows.Forms.Padding(2);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomBBDD = "codeSpecie";
            this.swTextbox1.Size = new System.Drawing.Size(191, 20);
            this.swTextbox1.TabIndex = 8;
            // 
            // swTextbox2
            // 
            this.swTextbox2.CampBuit = true;
            this.swTextbox2.ClauForanea = false;
            this.swTextbox2.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox2.Location = new System.Drawing.Point(309, 175);
            this.swTextbox2.Margin = new System.Windows.Forms.Padding(2);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomBBDD = "descSpecie";
            this.swTextbox2.Size = new System.Drawing.Size(191, 20);
            this.swTextbox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(224, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "CodeSpecie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "DescSpecie";
            // 
            // GestioEspecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 496);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "GestioEspecies";
            this.Load += new System.EventHandler(this.GestioEspecies_Load);
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox1;
        private InCont.SWTextbox swTextbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
