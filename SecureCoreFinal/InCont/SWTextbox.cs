using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace InCont
{
    public class SWTextbox : TextBox
    {
        #region Inicializar
        public SWTextbox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // SWTextbox
            // 
            this.Enter += new System.EventHandler(this.SWTextbox_Enter);
            this.Leave += new System.EventHandler(this.SWTextbox_Leave);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.SWTextbox_Validating);
            this.ResumeLayout(false);

        }
        #endregion

        #region Interficie
        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }
        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        #endregion

        #region Propiedades
        //Indica el tipus de dada que haurà al textbox
        public enum TipusDada
        {
            Numero,
            Text,
            Codi
        }

        private TipusDada _DadaPermesa;

        public TipusDada DadaPermesa
        {
            get { return _DadaPermesa; }
            set
            {
                _DadaPermesa = value;
            }

        }
        //Indica si pot sortir del text box amb el camp buit
        private bool _CampBuit;

        public bool CampBuit
        {
            get { return _CampBuit; }
            set
            {
                _CampBuit = value;
            }

        }
        //Indica si és una clau foranea
        private bool _ClauForanea;

        public bool ClauForanea
        {
            get { return _ClauForanea; }
            set
            {
                _ClauForanea = value;
            }

        }

        //Revisio que sigui correcte
        private String _NomBBDD;

        public string NomBBDD
        {
            get { return _NomBBDD; }
            set { _NomBBDD = value; }
        }
        #endregion

        #region Verificar
        private bool VerificaPattern(string dada, string patro)
        {
            bool FinalResult = false;

            Regex rgx = new Regex(patro);
            FinalResult = rgx.IsMatch(dada);

            return FinalResult;
        }

        private void SWTextbox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string patro = ""; //Revisar
            bool buit;

            if (DadaPermesa.ToString() == TipusDada.Numero.ToString())
            {
                patro = @"^\d{1,}$";
            }
            else if (DadaPermesa.ToString() == TipusDada.Codi.ToString())
            {
                patro = @"^[A-Z]{4}\-\d{3}\/[13579][AEIOUaeiou]$";
            }

            if (CampBuit)
            {
                buit = true;
            }
            else
            {
                buit = false;
            }

            if (VerificaPattern(this.Text, patro) || buit)
            {
                e.Cancel = false;

                if (ClauForanea == true)
                {
                    Control ctr = this.Parent;

                    foreach (Control item in ctr.Controls)
                    {
                        if (item.Name == this.NomBBDD)//No correcte, seria posar el camp SWCodi?
                        {
                            item.Text = this.Text;
                        }
                    }
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}