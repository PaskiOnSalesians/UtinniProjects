
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
            this.swTextbox1 = new InCont.SWTextbox();
            this.swTextbox2 = new InCont.SWTextbox();
            this.swTextbox3 = new InCont.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_codi = new System.Windows.Forms.Label();
            this.lbl_desc = new System.Windows.Forms.Label();
            this.lbl_AccessLevel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(733, 9);
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampBuit = false;
            this.swTextbox1.ClauForanea = false;
            this.swTextbox1.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox1.Location = new System.Drawing.Point(297, 119);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomBBDD = "CodeCategory";
            this.swTextbox1.Size = new System.Drawing.Size(147, 20);
            this.swTextbox1.TabIndex = 8;
            // 
            // swTextbox2
            // 
            this.swTextbox2.CampBuit = false;
            this.swTextbox2.ClauForanea = false;
            this.swTextbox2.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox2.Location = new System.Drawing.Point(297, 156);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomBBDD = "DescCategory";
            this.swTextbox2.Size = new System.Drawing.Size(147, 20);
            this.swTextbox2.TabIndex = 9;
            // 
            // swTextbox3
            // 
            this.swTextbox3.CampBuit = false;
            this.swTextbox3.ClauForanea = false;
            this.swTextbox3.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox3.Location = new System.Drawing.Point(297, 196);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.NomBBDD = "AccessLevel";
            this.swTextbox3.Size = new System.Drawing.Size(147, 20);
            this.swTextbox3.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
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
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "GestioCategories";
            this.Text = "GestioCategories";
            this.Load += new System.EventHandler(this.GestioCategories_Load);
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.lbl_codi, 0);
            this.Controls.SetChildIndex(this.lbl_desc, 0);
            this.Controls.SetChildIndex(this.lbl_AccessLevel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox1;
        private InCont.SWTextbox swTextbox2;
        private InCont.SWTextbox swTextbox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_codi;
        private System.Windows.Forms.Label lbl_desc;
        private System.Windows.Forms.Label lbl_AccessLevel;
    }
}