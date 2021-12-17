
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
            this.dgvGeneral = new System.Windows.Forms.DataGridView();
            this.btnActualitzar = new System.Windows.Forms.Button();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.lblExit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneral
            // 
            this.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGeneral.Location = new System.Drawing.Point(63, 255);
            this.dgvGeneral.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvGeneral.Name = "dgvGeneral";
            this.dgvGeneral.RowHeadersWidth = 51;
            this.dgvGeneral.RowTemplate.Height = 24;
            this.dgvGeneral.Size = new System.Drawing.Size(635, 169);
            this.dgvGeneral.TabIndex = 0;
            // 
            // btnActualitzar
            // 
            this.btnActualitzar.Location = new System.Drawing.Point(487, 435);
            this.btnActualitzar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualitzar.Name = "btnActualitzar";
            this.btnActualitzar.Size = new System.Drawing.Size(82, 25);
            this.btnActualitzar.TabIndex = 3;
            this.btnActualitzar.Text = "Actualitzar";
            this.btnActualitzar.UseVisualStyleBackColor = true;
            this.btnActualitzar.Click += new System.EventHandler(this.btnActualitzar_Click);
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(580, 435);
            this.btnInsertar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(118, 25);
            this.btnInsertar.TabIndex = 4;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertarDataSet_Click);
            // 
            // lblExit
            // 
            this.lblExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblExit.AutoSize = true;
            this.lblExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExit.Location = new System.Drawing.Point(796, 9);
            this.lblExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblExit.Name = "lblExit";
            this.lblExit.Size = new System.Drawing.Size(27, 31);
            this.lblExit.TabIndex = 7;
            this.lblExit.Text = "x";
            this.lblExit.Click += new System.EventHandler(this.lblExit_Click);
            // 
            // frmSimple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(834, 520);
            this.Controls.Add(this.lblExit);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.btnActualitzar);
            this.Controls.Add(this.dgvGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmSimple";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmSimple_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneral)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
       
        private System.Windows.Forms.Button btnActualitzar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeAgencyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descAgencyDataGridViewTextBoxColumn;
        public System.Windows.Forms.DataGridView dgvGeneral;
        public System.Windows.Forms.Label lblExit;
    }
}

