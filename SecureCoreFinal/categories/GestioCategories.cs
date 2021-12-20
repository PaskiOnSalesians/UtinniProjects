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

namespace categories
{
    public partial class GestioCategories : frmSimple
    {
        UserCategoriesEntities db;
        List<UserCategory> userCat;

        bool EsNou = false;

        public GestioCategories(string taula)
        {
            InitializeComponent();
            nomTaula = taula;
        }

        private void GestioCategories_Load(object sender, EventArgs e)
        {
            CarregaDades();
            dgvGeneral.Columns["idUserCategory"].Visible = false;
        }

        private void CarregaDades()
        {
            db = new UserCategoriesEntities();

            userCat = db.UserCategories.ToList();
            dgvGeneral.DataSource = userCat;

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
                    ctr.DataBindings.Add("Text", userCat, ctr.NomBBDD); // Introdueix les dades com a Text dins del TextBox
                    ctr.Validated += new System.EventHandler(this.VerifyDB);
                }
            }
        }

        public new void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (EsNou)
            {
                UserCategory usrCat = new UserCategory
                {
                    CodeCategory = swTextbox_code.Text,
                    DescCategory = swTextbox_desc.Text,
                    AccessLevel = Int32.Parse(swTextbox_level.Text)
                };
                db.UserCategories.Add(usrCat);
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
