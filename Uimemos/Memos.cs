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
        int cont = 0;
        Datos.cMemos memo = new Datos.cMemos();
        
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
                memo.InsertarEnBaseDatos(memo);
                MessageBox.Show("Se ha insertado con éxito", "Memorando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                limpiar();


            }
            else { MessageBox.Show("Todos los campos deben estar llenos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information); }

            rptmemorando reporte = new rptmemorando();
            reporte.nmemo = memo.nmemo;
            reporte.ShowDialog();
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
            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            
            else
            {
                e.Handled = true;
            }

            
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
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

    }
}
