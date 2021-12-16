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
            this.swTextboxDesc = new InCont.SWTextbox();
            this.swTextboxCodi = new InCont.SWTextbox();
            this.lbl_Desc = new System.Windows.Forms.Label();
            this.lbl_Codi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(723, 9);
            // 
            // swTextboxDesc
            // 
            this.swTextboxDesc.CampBuit = true;
            this.swTextboxDesc.ClauForanea = false;
            this.swTextboxDesc.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextboxDesc.Location = new System.Drawing.Point(186, 138);
            this.swTextboxDesc.Margin = new System.Windows.Forms.Padding(2);
            this.swTextboxDesc.Name = "swTextboxDesc";
            this.swTextboxDesc.NomBBDD = "descSpecie";
            this.swTextboxDesc.Size = new System.Drawing.Size(191, 20);
            this.swTextboxDesc.TabIndex = 8;
            // 
            // swTextboxCodi
            // 
            this.swTextboxCodi.CampBuit = false;
            this.swTextboxCodi.ClauForanea = false;
            this.swTextboxCodi.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextboxCodi.Location = new System.Drawing.Point(186, 89);
            this.swTextboxCodi.Name = "swTextboxCodi";
            this.swTextboxCodi.NomBBDD = "codiSpecie";
            this.swTextboxCodi.Size = new System.Drawing.Size(191, 20);
            this.swTextboxCodi.TabIndex = 9;
            // 
            // lbl_Desc
            // 
            this.lbl_Desc.AutoSize = true;
            this.lbl_Desc.Location = new System.Drawing.Point(99, 141);
            this.lbl_Desc.Name = "lbl_Desc";
            this.lbl_Desc.Size = new System.Drawing.Size(68, 13);
            this.lbl_Desc.TabIndex = 10;
            this.lbl_Desc.Text = "DescSpecie:";
            // 
            // lbl_Codi
            // 
            this.lbl_Codi.AutoSize = true;
            this.lbl_Codi.Location = new System.Drawing.Point(99, 89);
            this.lbl_Codi.Name = "lbl_Codi";
            this.lbl_Codi.Size = new System.Drawing.Size(64, 13);
            this.lbl_Codi.TabIndex = 11;
            this.lbl_Codi.Text = "CodiSpecie:";
            // 
            // GestioEspecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 496);
            this.Controls.Add(this.lbl_Codi);
            this.Controls.Add(this.lbl_Desc);
            this.Controls.Add(this.swTextboxCodi);
            this.Controls.Add(this.swTextboxDesc);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "GestioEspecies";
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextboxDesc, 0);
            this.Controls.SetChildIndex(this.swTextboxCodi, 0);
            this.Controls.SetChildIndex(this.lbl_Desc, 0);
            this.Controls.SetChildIndex(this.lbl_Codi, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextboxDesc;
        private InCont.SWTextbox swTextboxCodi;
        private System.Windows.Forms.Label lbl_Desc;
        private System.Windows.Forms.Label lbl_Codi;
    }
}
