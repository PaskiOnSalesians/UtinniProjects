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
        private void button1_Click(object sender, EventArgs e)
        {
            bool bFormNameOpen = false;

            FormCollection fc = Application.OpenForms;
            foreach (Form frm in fc)
            {
                if (frm.Name == "frmLlenca")
                {
                    bFormNameOpen = true;
                }
            }

            Assembly ensamblat = Assembly.LoadFrom(Classe);

            Object dllBD;

            Type tipus;

            tipus = ensamblat.GetType(Formulari);

            dllBD = Activator.CreateInstance(tipus);


            if (!bFormNameOpen)
            {
                ((Form)dllBD).Show();
            }

        }
        #endregion

        // Eventos
        #region Eventos
        private void LlancaApp_Load(object sender, EventArgs e)
        {
            button1.Text = Descripcio;
        }
        #endregion
    }
}
