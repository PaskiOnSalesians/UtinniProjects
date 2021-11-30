using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace UsControl
{
    public partial class LlancaApp: UserControl
    {
        public LlancaApp()
        {
            InitializeComponent();
        }

        // Propietats de LlancaApp
        #region Propietats

        // Propietat Classe
        private string _Classe;
        public string Classe
        {
            get { return _Classe; }
            set { _Classe = value; }
        }

        // Propietat Formulari
        private string _Formulari;
        public string Formulari
        {
            get { return _Formulari; }
            set { _Formulari = value; }
        }

        // Propietat Descripcio
        private string _desc;
        public string Descripcio
        {
            get { return _desc; }
            set { _desc = value; }
        }
        #endregion

        // Botones
        #region Botones
        private void btnLlenca_Click(object sender, EventArgs e)
        {
            Form frm;

            Assembly ensamblat = Assembly.LoadFrom(Classe);

            Object dllBD;
            Type tipus;

            frm = this.FindForm();

            foreach (Control ctrl in frm.Controls)
            {
                if (ctrl.Name.Equals("pnlMid"))
                {
                    tipus = ensamblat.GetType(Formulari);
                    dllBD = Activator.CreateInstance(tipus);
                    ((Form)dllBD).TopLevel = false;
                    ctrl.Controls.Add(((Form)dllBD));
                    ((Form)dllBD).Dock = DockStyle.Fill;
                    ((Form)dllBD).Show();
                }
            }
        }
        #endregion

        // Eventos
        #region Eventos
        private void LlancaApp_Load(object sender, EventArgs e)
        {
            btnLlenca.Text = Descripcio;
        }
        #endregion
    }
}
