using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;

namespace agricultorApp.app_rel
{
    public partial class relClientesForm : Form
    {
        public relClientesForm()
        {
            InitializeComponent();
        }

        private void relClientesForm_Load(object sender, EventArgs e)
        {
            ReportDocument rd = new ReportDocument();
            rd.Load(@"C:\Users\Andre Bessa\Desktop\Projetos\Projeto Emanuel\sistema\agricultorApp\agricultorApp\app_rel\relClientes.rpt");
            crystalReportViewer1.ReportSource = rd;
        }
    }
}
