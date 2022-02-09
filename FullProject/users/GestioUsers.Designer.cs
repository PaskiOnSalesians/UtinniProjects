
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
            this.swTextbox_password = new InCont.SWTextbox();
            this.swTextbox_login = new InCont.SWTextbox();
            this.swTextbox_photo = new InCont.SWTextbox();
            this.lbl_codi = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_photo = new System.Windows.Forms.Label();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.TarjaUser1 = new users.TarjaUser();
            this.LlistatBoto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblExit
            // 
            this.lblExit.Location = new System.Drawing.Point(1176, 14);
            this.lblExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            // 
            // swTextbox_codi
            // 
            this.swTextbox_codi.CampBuit = false;
            this.swTextbox_codi.ClauForanea = false;
            this.swTextbox_codi.DadaPermesa = InCont.SWTextbox.TipusDada.Codi;
            this.swTextbox_codi.Location = new System.Drawing.Point(494, 154);
            this.swTextbox_codi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox_codi.Name = "swTextbox_codi";
            this.swTextbox_codi.NomBBDD = "CodeUser";
            this.swTextbox_codi.Size = new System.Drawing.Size(271, 26);
            this.swTextbox_codi.TabIndex = 8;
            // 
            // swTextbox_desc
            // 
            this.swTextbox_desc.CampBuit = false;
            this.swTextbox_desc.ClauForanea = false;
            this.swTextbox_desc.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox_desc.Location = new System.Drawing.Point(494, 194);
            this.swTextbox_desc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox_desc.Name = "swTextbox_desc";
            this.swTextbox_desc.NomBBDD = "UserName";
            this.swTextbox_desc.Size = new System.Drawing.Size(271, 26);
            this.swTextbox_desc.TabIndex = 9;
            this.swTextbox_desc.TextChanged += new System.EventHandler(this.swTextbox_desc_TextChanged);
            // 
            // swTextbox_password
            // 
            this.swTextbox_password.CampBuit = false;
            this.swTextbox_password.ClauForanea = false;
            this.swTextbox_password.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox_password.Location = new System.Drawing.Point(494, 274);
            this.swTextbox_password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox_password.Name = "swTextbox_password";
            this.swTextbox_password.NomBBDD = "Password";
            this.swTextbox_password.Size = new System.Drawing.Size(271, 26);
            this.swTextbox_password.TabIndex = 11;
            // 
            // swTextbox_login
            // 
            this.swTextbox_login.CampBuit = false;
            this.swTextbox_login.ClauForanea = false;
            this.swTextbox_login.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox_login.Location = new System.Drawing.Point(494, 234);
            this.swTextbox_login.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox_login.Name = "swTextbox_login";
            this.swTextbox_login.NomBBDD = "Login";
            this.swTextbox_login.Size = new System.Drawing.Size(271, 26);
            this.swTextbox_login.TabIndex = 10;
            // 
            // swTextbox_photo
            // 
            this.swTextbox_photo.CampBuit = false;
            this.swTextbox_photo.ClauForanea = false;
            this.swTextbox_photo.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextbox_photo.Location = new System.Drawing.Point(494, 314);
            this.swTextbox_photo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.swTextbox_photo.Name = "swTextbox_photo";
            this.swTextbox_photo.NomBBDD = "Photo";
            this.swTextbox_photo.Size = new System.Drawing.Size(271, 26);
            this.swTextbox_photo.TabIndex = 12;
            // 
            // lbl_codi
            // 
            this.lbl_codi.AutoSize = true;
            this.lbl_codi.Location = new System.Drawing.Point(326, 158);
            this.lbl_codi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_codi.Name = "lbl_codi";
            this.lbl_codi.Size = new System.Drawing.Size(45, 20);
            this.lbl_codi.TabIndex = 13;
            this.lbl_codi.Text = "Codi:";
            // 
            // lbl_user
            // 
            this.lbl_user.AutoSize = true;
            this.lbl_user.Location = new System.Drawing.Point(326, 198);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(87, 20);
            this.lbl_user.TabIndex = 14;
            this.lbl_user.Text = "Username:";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Location = new System.Drawing.Point(326, 238);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(52, 20);
            this.lbl_login.TabIndex = 15;
            this.lbl_login.Text = "Login:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(326, 278);
            this.lbl_password.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(82, 20);
            this.lbl_password.TabIndex = 16;
            this.lbl_password.Text = "Password:";
            // 
            // lbl_photo
            // 
            this.lbl_photo.AutoSize = true;
            this.lbl_photo.Location = new System.Drawing.Point(326, 318);
            this.lbl_photo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_photo.Name = "lbl_photo";
            this.lbl_photo.Size = new System.Drawing.Size(55, 20);
            this.lbl_photo.TabIndex = 17;
            this.lbl_photo.Text = "Photo:";
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = 0;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(70, 741);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.ReportSource = this.TarjaUser1;
            this.crystalReportViewer1.Size = new System.Drawing.Size(1147, 455);
            this.crystalReportViewer1.TabIndex = 18;
            // 
            // LlistatBoto
            // 
            this.LlistatBoto.Location = new System.Drawing.Point(216, 673);
            this.LlistatBoto.Name = "LlistatBoto";
            this.LlistatBoto.Size = new System.Drawing.Size(155, 30);
            this.LlistatBoto.TabIndex = 19;
            this.LlistatBoto.Text = "Llistat";
            this.LlistatBoto.UseVisualStyleBackColor = true;
            this.LlistatBoto.Click += new System.EventHandler(this.LlistatBoto_Click);
            // 
            // GestioUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 962);
            this.Controls.Add(this.LlistatBoto);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.lbl_photo);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_user);
            this.Controls.Add(this.lbl_codi);
            this.Controls.Add(this.swTextbox_photo);
            this.Controls.Add(this.swTextbox_password);
            this.Controls.Add(this.swTextbox_login);
            this.Controls.Add(this.swTextbox_desc);
            this.Controls.Add(this.swTextbox_codi);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GestioUsers";
            this.Text = "GestioUsers";
            this.Controls.SetChildIndex(this.lblExit, 0);
            this.Controls.SetChildIndex(this.swTextbox_codi, 0);
            this.Controls.SetChildIndex(this.swTextbox_desc, 0);
            this.Controls.SetChildIndex(this.swTextbox_login, 0);
            this.Controls.SetChildIndex(this.swTextbox_password, 0);
            this.Controls.SetChildIndex(this.swTextbox_photo, 0);
            this.Controls.SetChildIndex(this.lbl_codi, 0);
            this.Controls.SetChildIndex(this.lbl_user, 0);
            this.Controls.SetChildIndex(this.lbl_login, 0);
            this.Controls.SetChildIndex(this.lbl_password, 0);
            this.Controls.SetChildIndex(this.lbl_photo, 0);
            this.Controls.SetChildIndex(this.crystalReportViewer1, 0);
            this.Controls.SetChildIndex(this.LlistatBoto, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InCont.SWTextbox swTextbox_codi;
        private InCont.SWTextbox swTextbox_desc;
        private InCont.SWTextbox swTextbox_password;
        private InCont.SWTextbox swTextbox_login;
        private InCont.SWTextbox swTextbox_photo;
        private System.Windows.Forms.Label lbl_codi;
        private System.Windows.Forms.Label lbl_user;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_photo;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private TarjaUser TarjaUser1;
        private System.Windows.Forms.Button LlistatBoto;
    }
}