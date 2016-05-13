using Datos;
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
    public partial class Memos : Form
    {
        
        Datos.cMemos memo = new Datos.cMemos();
        cValidar val = new cValidar();
        public Memos()
        {
            
            
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void toolRevision_Click(object sender, EventArgs e)
        {
            Revision revisar = new Revision();
            this.Hide();
            revisar.Show();


        }

        private void toolDepartamento_Click(object sender, EventArgs e)
        {
            departamento dpto = new departamento();
            this.Hide();
            dpto.Show();
        }

        private void toolTecnico_Click(object sender, EventArgs e)
        {
            tecnico tec = new tecnico();
            this.Hide();
            tec.Show();
        }

        private void toolDispositivo_Click(object sender, EventArgs e)
        {
            Dispositivo dispo = new Dispositivo();
            this.Hide();
            dispo.Show();
        }

        private void toolHome_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            this.Hide();
            inicio.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }
        

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar() == false)
            {
                memo= memo.obtnum();
                memo.nmemo = (memo.nmemo)+1;
                memo.destinatario = txtdestinatario.Text;
                memo.descripcion = txtDescripcion.Text;
                memo.motivo = txtmotivo.Text;
                memo.fecha = dateTimePicker1.Value.ToString("yyyyMMdd");
                
                 DialogResult resul = MessageBox.Show("¿Esta seguro de los datos?", "Registrar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                 if (resul == DialogResult.Yes)
                 {

                     memo.InsertarEnBaseDatos(memo);
                     MessageBox.Show("Se ha insertado con éxito", "Memorando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     limpiar();
                     //reportemorandoo reporte = new reportemorandoo();
                     ////reporte.fecha = memo.fecha;
                     FrmReportmemo objform = new FrmReportmemo();
                     objform.nmemo = memo.nmemo;
                     objform.ShowDialog();
                 }


            }
            else { MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            
        }


        public void limpiar()
        {
            foreach (Control ctrl in this.panelmemo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;

                }
            }
        }
        private void txtdestinatario_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sololetras(e);   
        }
        public bool validar()
        {
            foreach (Control c in this.panelmemo.Controls)
            {
                if (c is TextBox & c.Text == String.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        

        private void Memos_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);
        }

        private void txtmotivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            val.sololetras(e);
        }

    }
}
