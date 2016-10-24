﻿using System;
using System.Data;
using System.Windows.Forms;

namespace StockVentas
{
    public partial class frmVentasPesosDiarias : Form
    {
        DataTable tblVentasPesosDiarias;
        string desde;
        string hasta;
        string local;

        public frmVentasPesosDiarias(DataTable tblVentasPesosDiarias, string desde, string hasta, string local)
        {
            InitializeComponent();
            this.tblVentasPesosDiarias = tblVentasPesosDiarias;
            this.desde = desde;
            this.hasta = hasta;
            this.local = local;
        }

        private void frmVentasPesosDiarias_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.Text = "Ventas diarias en pesos";
            this.CenterToScreen();
            this.MaximizeBox = false;
            lblLocal.Text = "Local: " + local;
            lblDesde.Text = "Desde: " + desde;
            lblHasta.Text = "Hasta: " + hasta;
            dgvVentas.DataSource = tblVentasPesosDiarias;
            dgvVentas.Columns["Total"].DefaultCellStyle.Format = "C2";
            dgvVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void dgvVentas_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            return;
        }
    }
}