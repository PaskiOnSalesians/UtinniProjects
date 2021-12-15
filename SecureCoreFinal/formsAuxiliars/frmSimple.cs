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
        Form frm;

        //string query = "Select * from Agencies";
        //string nomTaula = "Agencies";
        string query = "";
        string nomTaula = "";
        DataSet dts;
        bool verify = false;

        public frmSimple()
        {
            InitializeComponent();
        }

        // Inicialitzar DataBindings
        public void DBinding()
        {
            frm = this.FindForm();

            foreach (TextBox txt in frm.Controls)
            {
                txt.DataBindings.Clear(); // Borra el DataBinding
                txt.DataBindings.Add("Text", dts.Tables[0], txt.Tag.ToString()); // Introdueix les dades com a Text dins del TextBox
                txt.Validated += new System.EventHandler(this.VerifyDB);
            }

            
        }

        // Validar les Dades a la Base de Dades
        public void VerifyDB(object sender, EventArgs e)
        {
            if (((TextBox)sender).DataBindings.Count > 0)
            {
                ((TextBox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        //public void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{
        //    DataGridViewColumn viewDB = dgvGeneral.Columns[0];
        //    viewDB.Visible = false;

        //    dgvGeneral.Columns[1].HeaderText = "CodeAgency";
        //    dgvGeneral.Columns[2].HeaderText = "DescAgency";
        //}

        public void frmSimple_Load(object sender, EventArgs e)
        {
           
            _Dades.ConnectDB();
            dts = _Dades.PortarPerConsulta(query, nomTaula);
            dgvGeneral.DataSource = dts.Tables[0];
            DBinding();
        }

        public void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (verify)
            {
                foreach (TextBox txt in frm.Controls)
                {
                    DataRow DataR = dts.Tables[0].NewRow();

                    if (txt.Tag.ToString().Equals("Codi") || txt.Tag.ToString().Equals("Desc"))
                    {
                        DataR[txt.Tag.ToString()] = txt.Text;
                    }

                    dts.Tables[0].Rows.Add(DataR);
                }
            }
            if (swTextboxCodi.TextLength <= 12 && swTextboxAgencia.TextLength <= 50)
            {
                _Dades.Actualitzar(query, nomTaula, dts);
                _Dades.PortarPerConsulta(query, nomTaula);
                DBinding();
                verify = false;
            } else
            {
                MessageBox.Show("Codi text limit is 12, Agency text limit is 50.");
            }
        }

        public void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnInsertarDataSet_Click(object sender, EventArgs e)
        {
            foreach(TextBox txt in frm.Controls)
            {
                txt.DataBindings.Clear();

                txt.Clear();

                verify = true;
            }
        }
    }
}
