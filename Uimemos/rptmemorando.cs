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
    public partial class rptmemorando : Form
    {
        public rptmemorando()
        {
            InitializeComponent();
        }
        public int nmemo;

        private void rptmemorando_Load(object sender, EventArgs e)
        {
            Memorando objReport = new Memorando();
            objReport.SetParameterValue("@nmemo", nmemo);
            crystalReportViewer1.ReportSource = objReport;
        }
    }
}
