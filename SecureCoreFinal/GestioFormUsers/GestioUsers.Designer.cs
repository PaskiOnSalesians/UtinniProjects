
namespace GestioFormUsers
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
            this.swTextbox1 = new InCont.SWTextbox();
            this.swTextbox2 = new InCont.SWTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(762, 9);
            // 
            // swTextbox1
            // 
            this.swTextbox1.CampBuit = false;
            this.swTextbox1.ClauForanea = false;
            this.swTextbox1.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox1.Location = new System.Drawing.Point(346, 117);
            this.swTextbox1.Name = "swTextbox1";
            this.swTextbox1.NomBBDD = null;
            this.swTextbox1.Size = new System.Drawing.Size(161, 20);
            this.swTextbox1.TabIndex = 8;
            // 
            // swTextbox2
            // 
            this.swTextbox2.CampBuit = false;
            this.swTextbox2.ClauForanea = false;
            this.swTextbox2.DadaPermesa = InCont.SWTextbox.TipusDada.Numero;
            this.swTextbox2.Location = new System.Drawing.Point(346, 163);
            this.swTextbox2.Name = "swTextbox2";
            this.swTextbox2.NomBBDD = null;
            this.swTextbox2.Size = new System.Drawing.Size(161, 20);
            this.swTextbox2.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "label1";
            // 
            // GestioUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.swTextbox2);
            this.Controls.Add(this.swTextbox1);
            this.Name = "GestioUsers";
            this.Text = "GestioUsers";
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextbox1, 0);
            this.Controls.SetChildIndex(this.swTextbox2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox1;
        private InCont.SWTextbox swTextbox2;
        private System.Windows.Forms.Label label1;
    }
}