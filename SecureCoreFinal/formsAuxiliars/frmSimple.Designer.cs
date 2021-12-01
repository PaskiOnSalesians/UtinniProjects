
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
            this.secureCoreDataSet = new formsAuxiliars.SecureCoreDataSet();
            this.agenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.swTextboxCodi = new InCont.SWTextbox();
            this.swTextboxAgencia = new InCont.SWTextbox();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnVeureDataSet = new System.Windows.Forms.Button();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new formsAuxiliars.SecureCoreDataSetTableAdapters.UsersTableAdapter();
            this.agenciesTableAdapter = new formsAuxiliars.SecureCoreDataSetTableAdapters.AgenciesTableAdapter();
            this.lblCodi = new System.Windows.Forms.Label();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.AutoGenerateColumns = false;
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.DataSource = this.secureCoreDataSet;
            this.dgvGeneral.Location = new System.Drawing.Point(45, 113);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.RowHeadersWidth = 51;
            this.dgvGeneral.RowTemplate.Height = 24;
            this.dgvGeneral.Size = new System.Drawing.Size(544, 208);
            this.dgvGeneral.TabIndex = 0;
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
            // btnVeureDataSet
            // 
            this.btnVeureDataSet.Location = new System.Drawing.Point(431, 345);
            this.btnVeureDataSet.Name = "btnVeureDataSet";
            this.btnVeureDataSet.Size = new System.Drawing.Size(158, 31);
            this.btnVeureDataSet.TabIndex = 4;
            this.btnVeureDataSet.Text = "Veure DataSet";
            this.btnVeureDataSet.UseVisualStyleBackColor = true;
            this.btnVeureDataSet.Click += new System.EventHandler(this.btnVeureDataSet_Click);
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
            this.lblExit.Location = new System.Drawing.Point(836, 9);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(20, 20);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "X";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // frmSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 471);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.lblAgencia);
            this.Controls.Add(this.lblCodi);
            this.Controls.Add(this.btnVeureDataSet);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.swTextboxAgencia);
            this.Controls.Add(this.swTextboxCodi);
            this.Controls.Add(this.dgvGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSimple";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secureCoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneral;
        private SecureCoreDataSet secureCoreDataSet;
        private InCont.SWTextbox swTextboxCodi;
        private InCont.SWTextbox swTextboxAgencia;
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.Button btnVeureDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private SecureCoreDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource agenciesBindingSource;
        private SecureCoreDataSetTableAdapters.AgenciesTableAdapter agenciesTableAdapter;
        private System.Windows.Forms.Label lblCodi;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblExit;
    }
}

