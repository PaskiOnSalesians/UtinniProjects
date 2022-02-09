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

        // Entrada y salida del TextBox
        #region Eventos de Entrada y Salida
        private void SWTextbox_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Pink;
        }
        private void SWTextbox_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }
        #endregion

        // Propiedades TextBox
        #region Propiedades

        // Tipo de dato del TextBox
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

        // Campo vacio
        private bool _CampBuit;
        public bool CampBuit
        {
            get { return _CampBuit; }
            set
            {
                _CampBuit = value;
            }

        }

        // Clave Foránea
        private bool _ClauForanea;
        public bool ClauForanea
        {
            get { return _ClauForanea; }
            set
            {
                _ClauForanea = value;
            }
        }

        // Campo Base de Datos al que hace Referencia
        private string _NomBBDD;
        public string NomBBDD
        {
            get { return _NomBBDD; }
            set { _NomBBDD = value; }
        }
        #endregion

        // Verificaciones
        #region Verificar

        // Verificar el patrón
        private bool VerificaPattern(string dada, string patro)
        {
            bool FinalResult = false;

            Regex rgx = new Regex(patro);
            FinalResult = rgx.IsMatch(dada);

            return FinalResult;
        }

        // Validador Constante
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