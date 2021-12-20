
namespace sectors
{
    partial class GestioSectors
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
            this.swTextbox_code = new InCont.SWTextbox();
            this.swTextbox_remark = new InCont.SWTextbox();
            this.swTextbox_desc = new InCont.SWTextbox();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(953, 11);
            // 
            // swTextbox_code
            // 
            this.swTextbox_code.CampBuit = false;
            this.swTextbox_code.ClauForanea = false;
            this.swTextbox_code.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox_code.Location = new System.Drawing.Point(379, 82);
            this.swTextbox_code.Name = "swTextbox_code";
            this.swTextbox_code.NomBBDD = "CodeSector";
            this.swTextbox_code.Size = new System.Drawing.Size(297, 22);
            this.swTextbox_code.TabIndex = 8;
            // 
            // swTextbox_remark
            // 
            this.swTextbox_remark.CampBuit = false;
            this.swTextbox_remark.ClauForanea = false;
            this.swTextbox_remark.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox_remark.Location = new System.Drawing.Point(379, 177);
            this.swTextbox_remark.Name = "swTextbox_remark";
            this.swTextbox_remark.NomBBDD = "Remarks";
            this.swTextbox_remark.Size = new System.Drawing.Size(297, 22);
            this.swTextbox_remark.TabIndex = 9;
            // 
            // swTextbox_desc
            // 
            this.swTextbox_desc.CampBuit = false;
            this.swTextbox_desc.ClauForanea = false;
            this.swTextbox_desc.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox_desc.Location = new System.Drawing.Point(379, 128);
            this.swTextbox_desc.Name = "swTextbox_desc";
            this.swTextbox_desc.NomBBDD = "DescSector";
            this.swTextbox_desc.Size = new System.Drawing.Size(297, 22);
            this.swTextbox_desc.TabIndex = 10;
            // 
            // GestioSectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 624);
            this.Controls.Add(this.swTextbox_desc);
            this.Controls.Add(this.swTextbox_remark);
            this.Controls.Add(this.swTextbox_code);
            this.Name = "GestioSectors";
            this.Text = "GestioSectors";
            this.Load += new System.EventHandler(this.GestioSectors_Load);
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextbox_code, 0);
            this.Controls.SetChildIndex(this.swTextbox_remark, 0);
            this.Controls.SetChildIndex(this.swTextbox_desc, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox_code;
        private InCont.SWTextbox swTextbox_remark;
        private InCont.SWTextbox swTextbox_desc;
    }
}