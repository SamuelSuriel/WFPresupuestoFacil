﻿using LoginSistem.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFPresupuestoFacil_Presentable
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAtrasSetup_Click(object sender, EventArgs e)
        {
            Close();
            PanelPresupuesto panel = new();
            panel.ShowDialog();

        }
    }
}
