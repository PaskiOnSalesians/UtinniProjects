
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
            this.lbl_code = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_remark = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(715, 9);
            // 
            // swTextbox_code
            // 
            this.swTextbox_code.CampBuit = false;
            this.swTextbox_code.ClauForanea = false;
            this.swTextbox_code.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox_code.Location = new System.Drawing.Point(319, 109);
            this.swTextbox_code.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.swTextbox_code.Name = "swTextbox_code";
            this.swTextbox_code.NomBBDD = "CodeSector";
            this.swTextbox_code.Size = new System.Drawing.Size(224, 20);
            this.swTextbox_code.TabIndex = 8;
            // 
            // swTextbox_remark
            // 
            this.swTextbox_remark.CampBuit = false;
            this.swTextbox_remark.ClauForanea = false;
            this.swTextbox_remark.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox_remark.Location = new System.Drawing.Point(319, 186);
            this.swTextbox_remark.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.swTextbox_remark.Name = "swTextbox_remark";
            this.swTextbox_remark.NomBBDD = "Remarks";
            this.swTextbox_remark.Size = new System.Drawing.Size(224, 20);
            this.swTextbox_remark.TabIndex = 9;
            // 
            // swTextbox_desc
            // 
            this.swTextbox_desc.CampBuit = false;
            this.swTextbox_desc.ClauForanea = false;
            this.swTextbox_desc.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox_desc.Location = new System.Drawing.Point(319, 146);
            this.swTextbox_desc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.swTextbox_desc.Name = "swTextbox_desc";
            this.swTextbox_desc.NomBBDD = "DescSector";
            this.swTextbox_desc.Size = new System.Drawing.Size(224, 20);
            this.swTextbox_desc.TabIndex = 10;
            // 
            // lbl_code
            // 
            this.lbl_code.AutoSize = true;
            this.lbl_code.Location = new System.Drawing.Point(202, 112);
            this.lbl_code.Name = "lbl_code";
            this.lbl_code.Size = new System.Drawing.Size(66, 13);
            this.lbl_code.TabIndex = 11;
            this.lbl_code.Text = "CodeSector:";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(202, 149);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(66, 13);
            this.lbl_desc.TabIndex = 12;
            this.lbl_desc.Text = "DescSector:";
            // 
            // lbl_remark
            // 
            this.lbl_remark.AutoSize = true;
            this.lbl_remark.Location = new System.Drawing.Point(202, 189);
            this.lbl_remark.Name = "lbl_remark";
            this.lbl_remark.Size = new System.Drawing.Size(52, 13);
            this.lbl_remark.TabIndex = 13;
            this.lbl_remark.Text = "Remarks:";
            // 
            // GestioSectors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 507);
            this.Controls.Add(this.lbl_remark);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_code);
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
            this.Controls.SetChildIndex(this.lbl_code, 0);
            this.Controls.SetChildIndex(this.lbl_desc, 0);
            this.Controls.SetChildIndex(this.lbl_remark, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox_code;
        private InCont.SWTextbox swTextbox_remark;
        private InCont.SWTextbox swTextbox_desc;
        private System.Windows.Forms.Label lbl_code;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_remark;
    }
}