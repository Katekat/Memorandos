
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
    public partial class Revision : Form
    {
        Datos.cRevision rev = new Datos.cRevision();

     
        private void Revision_Load(object sender, EventArgs e)
        {
            nomdpto.DataSource = rev.mostrarNombredp();
            nomdpto.DisplayMember = "nombre";
            nomdpto.ValueMember = "codigodpto";
            nomdpto.SelectedIndex = 0;

            cbnom1.DataSource = rev.mostrarNombreTec();
            cbnom1.DisplayMember = "nombre";
            cbnom1.ValueMember = "cedula";
            cbnom1.SelectedIndex = 0;

            cbnom2.DataSource = rev.mostrarNombreTec();
            cbnom2.DisplayMember = "nombre";
            cbnom2.ValueMember = "cedula";
            cbnom2.SelectedIndex = 0;

            cbnom3.DataSource = rev.mostrarNombreTec();
            cbnom3.DisplayMember = "nombre";
            cbnom3.ValueMember = "cedula";
            cbnom3.SelectedIndex = 0;
            List<citem> lista = new List<citem>();

            lista.Add(new citem("Por revisar"));
            lista.Add(new citem("En revision"));
            lista.Add(new citem("Revisado"));
            lista.Add(new citem("Entregado"));
            


            cbstatus.DisplayMember = "Name";
            cbstatus.DataSource = lista;
        }



         public Revision()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Dispositivo dispositivo = new Dispositivo();
            this.Hide();
            dispositivo.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tecnico tec = new tecnico();
            this.Hide();
            tec.Show();
        }

        private void toolDpto_Click(object sender, EventArgs e)
        {
            departamento dpto = new departamento();
            this.Hide();
            dpto.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Memos memorando= new Memos();
            this.Hide();
            memorando.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (validar_Revision() == false)
            {
                if (validar() == false)
                {
                    {
                        rev.codigocontrol = int.Parse(txtCodigocontrol.Text);
                        rev.Nomdpto = nomdpto.SelectedValue.ToString();
                        rev.Dinicial = txtdiagnini.Text.ToString();
                        rev.fechaI = txtFechaen.Value.ToString("ddMMyyyy");
                        rev.status = cbstatus.SelectedValue.ToString();
                        rev.Dfinal = txtdiagfinal.Text.ToString();
                        rev.recomendaciones = txtrecomendaciones.Text.ToString();
                        rev.fechaF = fechasalida.Value.ToString("ddMMyyyy");
                        rev.InsertarEnBaseDatos(rev);
                        MessageBox.Show("Se ha insertado con éxito", "Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //limpiar();
                    }
                }
            }
            else
            {
                if ((int.Parse(txtCodigocontrol.Text) != rev.codigocontrol))
                {
                    DialogResult resul = MessageBox.Show("¿Desea Cambiar los datos del dispositivo?", "Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        if (validar() == false)
                        {
                            rev.Nomdpto = nomdpto.SelectedValue.ToString();
                            rev.Dinicial = txtdiagnini.Text.ToString();
                            rev.fechaI = txtFechaen.Value.ToString("ddMMyyyy");
                            rev.status = cbstatus.SelectedValue.ToString();
                            rev.Dfinal = txtdiagfinal.Text.ToString();
                            rev.recomendaciones = txtrecomendaciones.Text.ToString();
                            rev.fechaF = fechasalida.Value.ToString("ddMMyyyy");
                          
                       
                            //rev.actualizarRevision;
                            MessageBox.Show("Se han actualizado los datos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodigocontrol.ReadOnly = false;
                            //limpiar();
                        }
                        else { MessageBox.Show("Debe llenar los campos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }
                    else
                    {
                        nomdpto.SelectedValue = rev.Nomdpto;
                        txtdiagnini.Text = rev.Dinicial;
                        //txtFechaen.Value = rev.fechaI;
                        cbstatus.SelectedValue = rev.status;
                        txtdiagfinal.Text = rev.Dfinal;
                        txtrecomendaciones.Text = rev.recomendaciones;
                        //fechasalida.Value = rev.fechaF;
                    }
                }
                else
                {
                    MessageBox.Show(" La revision ya se encuentra registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }
        public void limpiar()
        {
            foreach (Control ctrl in this.panelRevision.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;

                }
            }
        }

     

        private void txtCodigocontrol_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true
                    ;
                return;
            }
        }
        public bool validar_Revision()
        {
            rev.BuscarnRevision(int.Parse(txtCodigocontrol.Text));
            if (rev.codigocontrol == int.Parse(txtCodigocontrol.Text))
            {
                return true;

            }
            else
            {

                return false;
            }
        }
        public bool validar()
        {
            foreach (Control c in this.panelfechayhora.Controls)
            {
                if (c is TextBox & c.Text == String.Empty)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
