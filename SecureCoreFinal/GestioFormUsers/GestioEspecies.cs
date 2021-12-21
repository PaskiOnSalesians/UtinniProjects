using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using formsAuxiliars;
using AccesDades;


namespace GestioFormUsers
{
    public partial class GestioEspecies: frmSimple
    {
        public GestioEspecies(string taula)
        {
            InitializeComponent();
            nomTaula = taula;
        }

        private void GestioEspecies_Load(object sender, EventArgs e)
        {
            dgvGeneral.Columns["idSpecie"].Visible = false;
        }
    }
}

