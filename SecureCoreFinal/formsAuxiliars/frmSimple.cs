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

        string query;
        DataSet dts;

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

        private void frmSimple_Load(object sender, EventArgs e)
        {
            query = "Select * from Agencies";

            dts = _Dades.PortarPerConsulta(query, "Agencies");
            dgvGeneral.DataSource = dts.Tables[0];

            DBinding();

            // TODO: This line of code loads data into the 'secureCoreDataSet.Agencies' table. You can move, or remove it, as needed.
            this.agenciesTableAdapter.Fill(this.secureCoreDataSet.Agencies);
            // TODO: This line of code loads data into the 'secureCoreDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.secureCoreDataSet.Users);
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            DBinding();
        }

        private void btnVeureDataSet_Click(object sender, EventArgs e)
        {

        }
    }
}
