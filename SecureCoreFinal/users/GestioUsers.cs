﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using formsAuxiliars;

namespace users
{
    public partial class GestioUsers: frmSimple
    {
        public GestioUsers(string taula)
        {
            InitializeComponent();
            nomTaula = taula;
        }
    }
}