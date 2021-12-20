
namespace categories
{
    partial class GestioCategories
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
            this.swTextbox_desc = new InCont.SWTextbox();
            this.swTextbox_level = new InCont.SWTextbox();
            this.lbl_codi = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_AccessLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(733, 9);
            // 
            // swTextbox_code
            // 
            this.swTextbox_code.CampBuit = false;
            this.swTextbox_code.ClauForanea = false;
            this.swTextbox_code.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox_code.Location = new System.Drawing.Point(297, 119);
            this.swTextbox_code.Name = "swTextbox_code";
            this.swTextbox_code.NomBBDD = "CodeCategory";
            this.swTextbox_code.Size = new System.Drawing.Size(147, 20);
            this.swTextbox_code.TabIndex = 8;
            // 
            // swTextbox_desc
            // 
            this.swTextbox_desc.CampBuit = false;
            this.swTextbox_desc.ClauForanea = false;
            this.swTextbox_desc.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox_desc.Location = new System.Drawing.Point(297, 156);
            this.swTextbox_desc.Name = "swTextbox_desc";
            this.swTextbox_desc.NomBBDD = "DescCategory";
            this.swTextbox_desc.Size = new System.Drawing.Size(147, 20);
            this.swTextbox_desc.TabIndex = 9;
            // 
            // swTextbox_level
            // 
            this.swTextbox_level.CampBuit = false;
            this.swTextbox_level.ClauForanea = false;
            this.swTextbox_level.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox_level.Location = new System.Drawing.Point(297, 196);
            this.swTextbox_level.Name = "swTextbox_level";
            this.swTextbox_level.NomBBDD = "AccessLevel";
            this.swTextbox_level.Size = new System.Drawing.Size(147, 20);
            this.swTextbox_level.TabIndex = 10;
            // 
            // lbl_codi
            // 
            this.lbl_codi.AutoSize = true;
            this.lbl_codi.Location = new System.Drawing.Point(207, 122);
            this.lbl_codi.Name = "lbl_codi";
            this.lbl_codi.Size = new System.Drawing.Size(31, 13);
            this.lbl_codi.TabIndex = 12;
            this.lbl_codi.Text = "Codi:";
            // 
            // lbl_desc
            // 
            this.lbl_desc.AutoSize = true;
            this.lbl_desc.Location = new System.Drawing.Point(207, 159);
            this.lbl_desc.Name = "lbl_desc";
            this.lbl_desc.Size = new System.Drawing.Size(60, 13);
            this.lbl_desc.TabIndex = 13;
            this.lbl_desc.Text = "Descripció:";
            // 
            // lbl_AccessLevel
            // 
            this.lbl_AccessLevel.AutoSize = true;
            this.lbl_AccessLevel.Location = new System.Drawing.Point(207, 199);
            this.lbl_AccessLevel.Name = "lbl_AccessLevel";
            this.lbl_AccessLevel.Size = new System.Drawing.Size(36, 13);
            this.lbl_AccessLevel.TabIndex = 14;
            this.lbl_AccessLevel.Text = "Level:";
            // 
            // GestioCategories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 503);
            this.Controls.Add(this.lbl_AccessLevel);
            this.Controls.Add(this.lbl_desc);
            this.Controls.Add(this.lbl_codi);
            this.Controls.Add(this.swTextbox_level);
            this.Controls.Add(this.swTextbox_desc);
            this.Controls.Add(this.swTextbox_code);
            this.Name = "GestioCategories";
            this.Text = "GestioCategories";
            this.Load += new System.EventHandler(this.GestioCategories_Load);
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextbox_code, 0);
            this.Controls.SetChildIndex(this.swTextbox_desc, 0);
            this.Controls.SetChildIndex(this.swTextbox_level, 0);
            this.Controls.SetChildIndex(this.lbl_codi, 0);
            this.Controls.SetChildIndex(this.lbl_desc, 0);
            this.Controls.SetChildIndex(this.lbl_AccessLevel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox_code;
        private InCont.SWTextbox swTextbox_desc;
        private InCont.SWTextbox swTextbox_level;
        private System.Windows.Forms.Label lbl_codi;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_AccessLevel;
    }
}