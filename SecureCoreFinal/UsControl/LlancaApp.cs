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

        private String _Classe;

        public string Classe
        {
            get { return _Classe; }
            set { _Classe = value; }
        }

        private String _Formulari;

        public string Formulari
        {
            get { return _Formulari; }
            set { _Formulari = value; }
        }

        private string _desc;

        public string Descripcio
        {
            get { return _desc; }
            set { _desc = value; }
        }


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
<<<<<<< Updated upstream

            if (!bFormNameOpen)
            {
                ((Form)dllBD).Show();
            }
=======
>>>>>>> Stashed changes
        }

        private void LlancaApp_Load(object sender, EventArgs e)
        {
            button1.Text = Descripcio;
        }
    }
}
