
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
            this.secureCoreDataSet = new formsAuxiliars.SecureCoreDataSet();
            this.agenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swTextboxCodi = new InCont.SWTextbox();
            this.swTextboxAgencia = new InCont.SWTextbox();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.usersTableAdapter = new formsAuxiliars.SecureCoreDataSetTableAdapters.UsersTableAdapter();
            this.agenciesTableAdapter = new formsAuxiliars.SecureCoreDataSetTableAdapters.AgenciesTableAdapter();
            this.lblCodi = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            this.agenciesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSet)).BeginInit();
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
            this.dgvGeneral.Location = new System.Drawing.Point(45, 113);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.RowHeadersWidth = 51;
            this.dgvGeneral.RowTemplate.Height = 24;
            this.dgvGeneral.Size = new System.Drawing.Size(544, 208);
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
            this.agenciesBindingSource2.DataSource = this.secureCoreDataSet;
            // 
            // secureCoreDataSet
            // 
            this.secureCoreDataSet.DataSetName = "SecureCoreDataSet";
            this.secureCoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // swTextboxCodi
            // 
            this.swTextboxCodi.CampBuit = false;
            this.swTextboxCodi.ClauForanea = false;
            this.swTextboxCodi.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextboxCodi.Location = new System.Drawing.Point(129, 22);
            this.swTextboxCodi.Name = "swTextboxCodi";
            this.swTextboxCodi.NomBBDD = null;
            this.swTextboxCodi.Size = new System.Drawing.Size(228, 22);
            this.swTextboxCodi.TabIndex = 1;
            this.swTextboxCodi.Tag = "CodeAgency";
            // 
            // swTextboxAgencia
            // 
            this.swTextboxAgencia.CampBuit = false;
            this.swTextboxAgencia.ClauForanea = false;
            this.swTextboxAgencia.DadaPermesa = InCont.SWTextbox.TipusDada.Text;
            this.swTextboxAgencia.Location = new System.Drawing.Point(129, 55);
            this.swTextboxAgencia.Name = "swTextboxAgencia";
            this.swTextboxAgencia.NomBBDD = null;
            this.swTextboxAgencia.Size = new System.Drawing.Size(228, 22);
            this.swTextboxAgencia.TabIndex = 2;
            this.swTextboxAgencia.Tag = "DescAgency";
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(305, 345);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(110, 31);
            this.btnActualitzar.TabIndex = 3;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(431, 345);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(158, 31);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertarDataSet_Click);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // agenciesTableAdapter
            // 
            this.agenciesTableAdapter.ClearBeforeFill = true;
            // 
            // lblCodi
            // 
            this.lblCodi.AutoSize = true;
            this.lblCodi.Location = new System.Drawing.Point(41, 26);
            this.lblCodi.Name = "lblCodi";
            this.lblCodi.Size = new System.Drawing.Size(36, 17);
            this.lblCodi.TabIndex = 5;
            this.lblCodi.Text = "Codi";
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Location = new System.Drawing.Point(41, 60);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(59, 17);
            this.lblAgencia.TabIndex = 6;
            this.lblAgencia.Text = "Agencia";
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblExit.Location = new System.Drawing.Point(832, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(20, 20);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // agenciesBindingSource1
            // 
            this.agenciesBindingSource1.DataMember = "Agencies";
            this.agenciesBindingSource1.DataSource = this.secureCoreDataSet;
            // 
            // frmSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 431);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.lblCodi);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.swTextboxAgencia);
            this.Controls.Add(this.swTextboxCodi);
            this.Controls.Add(this.dgvGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSimple";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneral;
        private SecureCoreDataSet secureCoreDataSet;
        private InCont.SWTextbox swTextboxCodi;
        private InCont.SWTextbox swTextboxAgencia;
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.Button btnInsertar;
        private SecureCoreDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource agenciesBindingSource;
        private SecureCoreDataSetTableAdapters.AgenciesTableAdapter agenciesTableAdapter;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblExit;
        private System.Windows.Forms.BindingSource agenciesBindingSource2;
        private System.Windows.Forms.BindingSource agenciesBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descAgencyDataGridViewTextBoxColumn;
    }
}

