
namespace users
{
    partial class GestioUsers
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
            this.swTextbox_codi = new InCont.SWTextbox();
            this.swTextbox_desc = new InCont.SWTextbox();
            this.swTextbox1 = new InCont.SWTextbox();
            this.swTextbox2 = new InCont.SWTextbox();
            this.swTextbox3 = new InCont.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // swTextbox_codi
            // 
            this.swTextbox_codi.CampBuit = false;
            this.swTextbox_codi.ClauForanea = false;
            this.swTextbox_codi.DadaPermesa = InCont.SWTextbox.TipusDada.Codi;
            this.swTextbox_codi.Location = new System.Drawing.Point(211, 100);
            this.swTextbox_codi.Name = "swTextbox_codi";
            this.swTextbox_codi.NomBBDD = "CodeUser";
            this.swTextbox_codi.Size = new System.Drawing.Size(182, 20);
            this.swTextbox_codi.TabIndex = 8;
            // 
            // swTextbox_desc
            // 
            this.swTextbox_desc.CampBuit = false;
            this.swTextbox_desc.ClauForanea = false;
            this.swTextbox_desc.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox_desc.Location = new System.Drawing.Point(211, 126);
            this.swTextbox_desc.Name = "swTextbox_desc";
            this.swTextbox_desc.NomBBDD = "UserName";
            this.swTextbox_desc.Size = new System.Drawing.Size(182, 20);
            this.swTextbox_desc.TabIndex = 9;
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampBuit = false;
            this.swTextbox1.ClauForanea = false;
            this.swTextbox1.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox1.Location = new System.Drawing.Point(211, 178);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomBBDD = "Password";
            this.swTextbox1.Size = new System.Drawing.Size(182, 20);
            this.swTextbox1.TabIndex = 11;
            // 
            // swTextbox2
            // 
            this.swTextbox2.CampBuit = false;
            this.swTextbox2.ClauForanea = false;
            this.swTextbox2.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox2.Location = new System.Drawing.Point(211, 152);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomBBDD = "Login";
            this.swTextbox2.Size = new System.Drawing.Size(182, 20);
            this.swTextbox2.TabIndex = 10;
            // 
            // swTextbox3
            // 
            this.swTextbox3.CampBuit = false;
            this.swTextbox3.ClauForanea = false;
            this.swTextbox3.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox3.Location = new System.Drawing.Point(211, 204);
            this.swTextbox3.Name = "swTextbox3";
            this.swTextbox3.NomBBDD = "Photo";
            this.swTextbox3.Size = new System.Drawing.Size(182, 20);
            this.swTextbox3.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Codi:";
            // 
            // GestioUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 485);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextbox3);
            this.Controls.Add(this.swTextbox1);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox_desc);
            this.Controls.Add(this.swTextbox_codi);
            this.Name = "GestioUsers";
            this.Text = "GestioUsers";
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextbox_codi, 0);
            this.Controls.SetChildIndex(this.swTextbox_desc, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox_codi;
        private InCont.SWTextbox swTextbox_desc;
        private InCont.SWTextbox swTextbox1;
        private InCont.SWTextbox swTextbox2;
        private InCont.SWTextbox swTextbox3;
        private System.Windows.Forms.Label label1;
    }
}