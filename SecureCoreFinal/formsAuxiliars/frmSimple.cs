using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InCont;

using AccesDades;


namespace formsAuxiliars
{
    public partial class frmSimple : Form
    {
        Dades _Dades = new Dades();
        Form frm;

        string query = "";
        public string nomTaula = "";
        DataSet dts;
        bool verify = false;

        public frmSimple()
        {
            InitializeComponent();
        }

        // Inicialitzar DataBindings
        public void DBinding()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is SWTextbox)
                {
                    SWTextbox ctr = (SWTextbox)txt;
                    ctr.DataBindings.Clear(); // Borra el DataBinding
                    ctr.DataBindings.Add("Text", dts.Tables[0], ctr.NomBBDD); // Introdueix les dades com a Text dins del TextBox
                    ctr.Validated += new System.EventHandler(this.VerifyDB);
                }
            }
        }

        // Validar les Dades a la Base de Dades
        public void VerifyDB(object sender, EventArgs e)
        {
            if (((SWTextbox)sender).DataBindings.Count > 0)
            {
                ((SWTextbox)sender).DataBindings[0].BindingManagerBase.EndCurrentEdit();
            }
        }

        public void frmSimple_Load(object sender, EventArgs e)
        {
            if (DesignMode) return;
            _Dades.ConnectDB();
            query = "select * from " + nomTaula;
            dts = _Dades.PortarPerConsulta(query, nomTaula);
            dgvGeneral.DataSource = dts.Tables[0];
            DBinding();
        }

        public void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (verify)
            {
                DataRow DataR = dts.Tables[0].NewRow();
                foreach (Control txt in frm.Controls)
                {
                    if (txt is SWTextbox)
                    {
                        SWTextbox ctr = (SWTextbox)txt;
                        DataR[ctr.NomBBDD] = ctr.Text;
                    }
                }
                dts.Tables[0].Rows.Add(DataR);
            }
            _Dades.Actualitzar(query, nomTaula, dts);
            _Dades.PortarPerConsulta(query, nomTaula);
            DBinding();
            verify = false;
        }

        public void lblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnInsertarDataSet_Click(object sender, EventArgs e)
        {
            verify = true;
            foreach (Control txt in frm.Controls)
            {
                if (txt is SWTextbox)
                {
                    SWTextbox ctr = (SWTextbox)txt;
                    ctr.DataBindings.Clear();
                    ctr.Clear();
                }
            }
        }
    }
}
