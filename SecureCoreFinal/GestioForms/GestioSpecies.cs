using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using formsAuxiliars;
using AccesDades;
using System.Windows.Forms;

namespace GestioForms
{
    public class GestioSpecies : frmSimple
    {
        Dades _Dades = new Dades();

        string query = "Select * from Species";
        string nomTaula = "Species";
        DataSet dts;
        bool verify = false;

        private new void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewColumn viewDB = dgvGeneral.Columns[0];
            viewDB.Visible = false;

            dgvGeneral.Columns[1].HeaderText = "CodeSpecie";
            dgvGeneral.Columns[2].HeaderText = "DescSpecie";
        }

        /*
        private new void frmSimple_Load(object sender, EventArgs e)
        {
            frmS.agenciesTableAdapter.Fill(frmSimple.secureCoreDataSet.Agencies);
            _Dades.ConnectDB();
            dts = _Dades.PortarPerConsulta(query, nomTaula);
            dgvGeneral.DataSource = dts.Tables[0];
            DBinding();
        }*/

        private new void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (verify)
            {
                DataRow DataR = dts.Tables[0].NewRow();
                DataR["CodeSpecie"] = swTextboxCodi.Text;
                DataR["DescSpecie"] = swTextboxAgencia.Text;
                dts.Tables[0].Rows.Add(DataR);
            }
            if (swTextboxCodi.TextLength <= 12 && swTextboxAgencia.TextLength <= 50)
            {
                _Dades.Actualitzar(query, nomTaula, dts);
                _Dades.PortarPerConsulta(query, nomTaula);
                DBinding();
                verify = false;
            }
            else
            {
                MessageBox.Show("Codi text limit is 12, Agency text limit is 50.");
            }
        }
    }
}
