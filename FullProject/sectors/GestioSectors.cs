using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SecureCoreFinal;
using formsAuxiliars;
using InCont;

namespace sectors
{
    public partial class GestioSectors : frmSimple
    {
        SectorsEntities db;
        List<Sectors> sect;

        bool EsNou = false;

        public GestioSectors(string taula)
        {
            InitializeComponent();
            nomTaula = taula;
        }

        private void GestioSectors_Load(object sender, EventArgs e)
        {
            CarregaDades();
            dgvGeneral.Columns["idSector"].Visible = false;
            dgvGeneral.Columns["idRegion"].Visible = false;
        }

        private void CarregaDades()
        {
            db = new SectorsEntities();

            sect = db.Sectors.ToList();
            dgvGeneral.DataSource = sect;

            DBinding();
        }

        private new void DBinding()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is SWTextbox)
                {
                    SWTextbox ctr = (SWTextbox)txt;
                    ctr.DataBindings.Clear(); // Borra el DataBinding
                    ctr.DataBindings.Add("Text", sect, ctr.NomBBDD); // Introdueix les dades com a Text dins del TextBox
                    ctr.Validated += new System.EventHandler(this.VerifyDB);
                }
            }
        }

        public new void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                Sectors sct = new Sectors
                {
                    CodeSector = swTextbox_code.Text,
                    DescSector = swTextbox_desc.Text,
                    Remarks = swTextbox_remark.Text
                };
                db.Sectors.Add(sct);
            }
            db.SaveChanges();
        }

        public new void btnInsertarDataSet_Click(object sender, EventArgs e)
        {
            EsNou = true;
            TreuBinding();
        }

        private void TreuBinding()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is SWTextbox)
                {
                    SWTextbox ctr = (SWTextbox)txt;
                    ctr.DataBindings.Clear(); // Borra el DataBinding
                    ctr.Text = "";
                }
            }
        }
    }
}
