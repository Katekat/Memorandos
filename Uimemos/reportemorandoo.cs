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
        
              
           

            //  //Parametro del campo
            //  ParameterField nmemo = new ParameterField();
            //  ParameterField fecha = new ParameterField();
            //  //Colección de parámetros de campo
            //  ParameterFields coleccionCamposParametros = new ParameterFields();
            //  //Valor del parámetro
            //  ParameterDiscreteValue crnmemo = new ParameterDiscreteValue();
            //  ParameterDiscreteValue crfecha = new ParameterDiscreteValue();

            //  //Nombre del primer Parámetro
            //  nmemo = "@FechaRegistro_Desde";

            //  //Especificar de donde obtendremos el valor del parámetro
            //  crParameterDiscreteValue1.Value = _fechaRegistro_Desde;

            //  //Pasamos el valor actual a la coleccion de campos parámetros el valor como parámetro 
            //  campoParametro_FechaDesde.CurrentValues.Add(crParameterDiscreteValue1);

            //  //Pasamos el campo a la colección de campos
            //  coleccionCamposParametros.Add(campoParametro_FechaDesde);

            //  //
            //  //Segundo Parámetro
            //  campoParametro_FechaHasta.Name = "@FechaRegistro_Hasta";
            //  //
            //  //Especificar de donde obtendremos el valor del parámetro
            //  crParameterDiscreteValue2.Value = _fechaRegistro_Hasta;
            //  //
            //  //Pasamos el valor actual a la coleccion de campos parámetros el valor
            //  campoParametro_FechaHasta.CurrentValues.Add(crParameterDiscreteValue2);
            //  //
            //  //Pasamos el campo a la colección
            //  coleccionCamposParametros.Add(campoParametro_FechaHasta);
            //-------------------------------------------------------------------------


            //ParameterFields paramFields = new ParameterFields();
            //// ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();

            //ParameterField paramField = new ParameterField();
            //ParameterDiscreteValue paramDiscreteValue = new ParameterDiscreteValue();
            //paramField.Name = "@nmemo";
            //paramDiscreteValue.Value = nmemo;
            //paramField.CurrentValues.Add(paramDiscreteValue);
            //paramFields.Add(paramField);

            //paramField = new ParameterField();
            //paramDiscreteValue = new ParameterDiscreteValue();  // <-- This line is added
            //paramField.Name = "@fecha";
            //paramDiscreteValue.Value = fecha;
            //paramField.CurrentValues.Add(paramDiscreteValue);
            //paramFields.Add(paramField);

            //crystalReportViewer1.ParameterFieldInfo = paramFields;
            //crystalReportViewer1.ReportSource = objreport;
        

        private void reportemorandoo_Load(object sender, EventArgs e)
        {
            CrystalReport1 objreport = new CrystalReport1();
            objreport.SetParameterValue("@nmemo", nmemo);
            objreport.SetParameterValue("@fecha", fecha);
            crystalReportViewer1.ReportSource = objreport;
            crystalReportViewer1.Show();

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

       

       
    }
        
}
