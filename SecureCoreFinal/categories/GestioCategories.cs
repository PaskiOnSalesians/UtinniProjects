using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using formsAuxiliars;
using InCont;

namespace categories
{
    public partial class GestioCategories : frmSimple
    {
        UsersCategoriesEntities db;
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
        }

        private void CarregaDades()
        {
            db = new UsersCategoriesEntities();

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


    }
}
