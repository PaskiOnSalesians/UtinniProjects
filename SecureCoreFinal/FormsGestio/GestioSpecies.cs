﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

using formsAuxiliars;
using AccesDades;
using System.Data;

namespace FormsGestio
{
    public class GestioSpecies : frmSimple
    {
        Dades _Dades = new Dades();

        string query = "Select * from Agencies";
        DataSet dts;
        bool verify = false;

        private void DataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            DataGridViewColumn viewDB = dgvGeneral.Columns[0];
            viewDB.Visible = false;

            dgvGeneral.Columns[1].HeaderText = "CodeAgency";
            dgvGeneral.Columns[2].HeaderText = "DescAgency";
        }

        private void frmSimple_Load(object sender, EventArgs e)
        {
            this.agenciesTableAdapter.Fill(this.secureCoreDataSet.Agencies);
            _Dades.ConnectDB();
            dts = _Dades.PortarPerConsulta(query, "Agencies");
            dgvGeneral.DataSource = dts.Tables[0];
            DBinding();
        }

        private void btnActualitzar_Click(object sender, EventArgs e)
        {
            if (verify)
            {
                DataRow DataR = dts.Tables[0].NewRow();
                DataR["CodeAgency"] = swTextboxCodi.Text;
                DataR["DescAgency"] = swTextboxAgencia.Text;
                dts.Tables[0].Rows.Add(DataR);
            }
            if (swTextboxCodi.TextLength <= 12 && swTextboxAgencia.TextLength <= 50)
            {
                _Dades.Actualitzar(query, "Agencies", dts);
                _Dades.PortarPerConsulta(query, "Agencies");
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
