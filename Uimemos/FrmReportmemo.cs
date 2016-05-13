using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uimemos
{
    public partial class FrmReportmemo : Form
    {
        public FrmReportmemo()
        {
            InitializeComponent();
        }
        public int nmemo;
        private void FrmReportmemo_Load(object sender, EventArgs e)
        {
            Memosalc objreporte = new Memosalc();
            objreporte.SetParameterValue("@nmemo", nmemo);
            crystalReportViewer2.ReportSource = objreporte;
        }
    }
}
