using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AccesDades;


namespace formsAuxiliars
{
    public partial class frmSimple : Form
    {
        Dades _Dades = new Dades();

        string query = "Select * from Agencies";
        DataSet dts;
        bool verify = false;

        public frmSimple()
        {
            InitializeComponent();
        }

        // Inicialitzar DataBindings
        private void DBinding()
        {
            swTextboxCodi.DataBindings.Clear(); // Borra el DataBinding
            swTextboxCodi.DataBindings.Add("Text", dts.Tables[0], swTextboxCodi.Tag.ToString()); // Introdueix les dades com a Text dins del TextBox
            this.swTextboxCodi.Validated += new System.EventHandler(this.VerifyDB);

            swTextboxAgencia.DataBindings.Clear();
            swTextboxAgencia.DataBindings.Add("Text", dts.Tables[0], swTextboxAgencia.Tag.ToString());
            this.swTextboxAgencia.Validated += new System.EventHandler(this.VerifyDB);
        }

        // Validar les Dades a la Base de Dades
        private void VerifyDB(object sender, EventArgs e)
        {
            if (((TextBox)sender).DataBindings.Count > 0)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewColumn viewDB = dgvGeneral.Columns[0];
            viewDB.Visible = false;

            dgvGeneral.Columns[1].HeaderText = "CodeAgency";
            dgvGeneral.Columns[2].HeaderText = "DescAgency";
        }

        private void frmSimple_Load(object sender, EventArgs e)
        {
            this.agenciesTableAdapter.Fill(this.secureCoreDataSet.Agencies);
            _Dades.ConnectDB();
            dts = _Dades.PortarPerConsulta(query, "Agencies");
            dgvGeneral.DataSource = dts.Tables[0];
            DBinding();
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (verify)
            {
                DataRow DataR = dts.Tables[0].NewRow();
                DataR["CodeAgency"] = swTextboxCodi.Text;
                DataR["DescAgency"] = swTextboxAgencia.Text;
                dts.Tables[0].Rows.Add(DataR);
            }
            if (swTextboxCodi.TextLength <= 12 && swTextboxAgencia.TextLength <= 50)
            {
                _Dades.Actualitzar(query, "Agencies", dts);
                _Dades.PortarPerConsulta(query, "Agencies");
                DBinding();
                verify = false;
            } else
            {
                MessageBox.Show("Codi text limit is 12, Agency text limit is 50.");
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInsertarDataSet_Click(object sender, EventArgs e)
        {
            swTextboxCodi.DataBindings.Clear();
            swTextboxAgencia.DataBindings.Clear();

            swTextboxCodi.Clear();
            swTextboxAgencia.Clear();

            verify = true;
        }
    }
}
