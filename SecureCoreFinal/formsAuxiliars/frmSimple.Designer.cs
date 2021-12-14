
namespace formsAuxiliars
{
    partial class frmSimple
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
            this.components = new System.ComponentModel.Container();
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.idAgencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeAgencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descAgencyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agenciesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            
            this.agenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swTextboxCodi = new InCont.SWTextbox();
            this.swTextboxAgencia = new InCont.SWTextbox();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblCodi = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.agenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.AutoGenerateColumns = false;
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAgencyDataGridViewTextBoxColumn,
            this.codeAgencyDataGridViewTextBoxColumn,
            this.descAgencyDataGridViewTextBoxColumn});
            this.dgvGeneral.DataSource = this.agenciesBindingSource2;
            this.dgvGeneral.Location = new System.Drawing.Point(34, 92);
            this.dgvGeneral.Margin = new System.Windows.Forms.Padding(2);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.RowHeadersWidth = 51;
            this.dgvGeneral.RowTemplate.Height = 24;
            this.dgvGeneral.Size = new System.Drawing.Size(408, 169);
            this.dgvGeneral.TabIndex = 0;
            // 
            // idAgencyDataGridViewTextBoxColumn
            // 
            this.idAgencyDataGridViewTextBoxColumn.DataPropertyName = "idAgency";
            this.idAgencyDataGridViewTextBoxColumn.HeaderText = "idAgency";
            this.idAgencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idAgencyDataGridViewTextBoxColumn.Name = "idAgencyDataGridViewTextBoxColumn";
            this.idAgencyDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAgencyDataGridViewTextBoxColumn.Visible = false;
            this.idAgencyDataGridViewTextBoxColumn.Width = 125;
            // 
            // codeAgencyDataGridViewTextBoxColumn
            // 
            this.codeAgencyDataGridViewTextBoxColumn.DataPropertyName = "CodeAgency";
            this.codeAgencyDataGridViewTextBoxColumn.HeaderText = "CodeAgency";
            this.codeAgencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.codeAgencyDataGridViewTextBoxColumn.Name = "codeAgencyDataGridViewTextBoxColumn";
            this.codeAgencyDataGridViewTextBoxColumn.Width = 160;
            // 
            // descAgencyDataGridViewTextBoxColumn
            // 
            this.descAgencyDataGridViewTextBoxColumn.DataPropertyName = "DescAgency";
            this.descAgencyDataGridViewTextBoxColumn.HeaderText = "DescAgency";
            this.descAgencyDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descAgencyDataGridViewTextBoxColumn.Name = "descAgencyDataGridViewTextBoxColumn";
            this.descAgencyDataGridViewTextBoxColumn.Width = 160;
            // 
            // agenciesBindingSource2
            // 
            this.agenciesBindingSource2.DataMember = "Agencies";
            
            // swTextboxCodi
            // 
            this.swTextboxCodi.CampBuit = false;
            this.swTextboxCodi.ClauForanea = false;
            this.swTextboxCodi.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextboxCodi.Location = new System.Drawing.Point(97, 18);
            this.swTextboxCodi.Margin = new System.Windows.Forms.Padding(2);
            this.swTextboxCodi.Name = "swTextboxCodi";
            this.swTextboxCodi.NomBBDD = null;
            this.swTextboxCodi.Size = new System.Drawing.Size(172, 20);
            this.swTextboxCodi.TabIndex = 1;
            this.swTextboxCodi.Tag = "CodeAgency";
            // 
            // swTextboxAgencia
            // 
            this.swTextboxAgencia.CampBuit = false;
            this.swTextboxAgencia.ClauForanea = false;
            this.swTextboxAgencia.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextboxAgencia.Location = new System.Drawing.Point(97, 45);
            this.swTextboxAgencia.Margin = new System.Windows.Forms.Padding(2);
            this.swTextboxAgencia.Name = "swTextboxAgencia";
            this.swTextboxAgencia.NomBBDD = null;
            this.swTextboxAgencia.Size = new System.Drawing.Size(172, 20);
            this.swTextboxAgencia.TabIndex = 2;
            this.swTextboxAgencia.Tag = "DescAgency";
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(229, 280);
            this.btnActualitzar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(82, 25);
            this.btnActualitzar.TabIndex = 3;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(323, 280);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(118, 25);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertarDataSet_Click);
            // 
            // lblCodi
            // 
            this.lblCodi.AutoSize = true;
            this.lblCodi.Location = new System.Drawing.Point(31, 21);
            this.lblCodi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodi.Name = "lblCodi";
            this.lblCodi.Size = new System.Drawing.Size(28, 13);
            this.lblCodi.TabIndex = 5;
            this.lblCodi.Text = "Codi";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(31, 49);
            this.lblAgencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(46, 13);
            this.lblAgencia.TabIndex = 6;
            this.lblAgencia.Text = "Agencia";
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblExit.Location = new System.Drawing.Point(624, 7);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(17, 17);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // agenciesBindingSource1
            // 
            this.agenciesBindingSource1.DataMember = "Agencies";
            // 
            // frmSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 350);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.lblCodi);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.swTextboxAgencia);
            this.Controls.Add(this.swTextboxCodi);
            this.Controls.Add(this.dgvGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSimple";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.BindingSource agenciesBindingSource;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.BindingSource agenciesBindingSource2;
        private System.Windows.Forms.BindingSource agenciesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descAgencyDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvGeneral;
        public InCont.SWTextbox swTextboxCodi;
        public InCont.SWTextbox swTextboxAgencia;
    }
}

