using CrystalDecisions.Shared;
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
    public partial class reportemorandoo : Form
    {
        public reportemorandoo()
        {
            InitializeComponent();
        }

        public int nmemo;
        public string fecha;
        private void rptmemorando_Load(object sender, EventArgs e)
        {
              CrystalReport1 objreport= new CrystalReport1();
           
            ParameterFields paramFields = new ParameterFields();
            // ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            ParameterField paramField = new ParameterField();
            ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
            paramField.Name = "@nmemo";
            paramDiscreteValue.Value = nmemo;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            paramField = new ParameterField();
            paramDiscreteValue = new ParameterDiscreteValue();  // <-- This line is added
            paramField.Name = "@fecha";
            paramDiscreteValue.Value = fecha;
            paramField.CurrentValues.Add(paramDiscreteValue);
            paramFields.Add(paramField);

            crystalReportViewer1.ParameterFieldInfo = paramFields;
            crystalReportViewer1.ReportSource = objreport;
        }
    }
        
}
