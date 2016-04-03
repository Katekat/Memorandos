using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;

namespace Uimemos
{
    public partial class tecnico : Form
    {
        Datos.cTecnico tec = new Datos.cTecnico();
        public tecnico()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Dispositivo ventana1 = new Dispositivo();
            this.Hide();
            ventana1.Show();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Revision revisar = new Revision();
            this.Hide();
            revisar.Show();
        }

        

        private void txtCedula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                tec = tec.BuscarTecnico(txtCedula.Text);


                if (tec.cedula != null)
                {
                    txtCedula.Text = tec.cedula;
                    txtCedula.ReadOnly = Enabled;
                    txtNombre.Text = tec.nombre;
                    txtCargo.Text = tec.cargo;

                }
                else
                {
                    MessageBox.Show("TÉCNICO NO REGISTRADO", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        public bool validarTecnico()
        {
            if (txtCedula.Text != tec.cedula)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnGuardartecnico_Click(object sender, EventArgs e)
        {
            if (validarTecnico() == true)
            {
                if (validar() == false)
                {
                    tec.cedula = txtCedula.Text;
                    tec.cargo = txtCargo.Text;
                    tec.nombre = txtNombre.Text;
                    tec.InsertarEnBaseDatos(tec);
                    MessageBox.Show("Se ha insertado con éxito", "Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else { MessageBox.Show("Debe llenar los campos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            else
            {
                if ((txtNombre.Text != tec.nombre || txtCargo.Text != tec.cargo))
                {
                    DialogResult resul = MessageBox.Show("¿Desea Cambiar los datos del Técnico?", "Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        if (validar() == false)
                        {
                            tec.nombre = txtNombre.Text;
                            tec.cargo = txtCargo.Text;
                            tec.actualizarTecnico(tec);
                            MessageBox.Show("Se han actualizado los datos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCedula.ReadOnly = false;
                            limpiar();
                        }
                        else { MessageBox.Show("Debe llenar los campos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }
                    else
                    {
                        txtNombre.Text = tec.nombre;
                        txtCargo.Text = tec.cargo;
                    }
                }
                else
                {
                    MessageBox.Show(" El tecnico ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }


        public void limpiar()
        {
            foreach (Control ctrl in this.paneltec.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;

                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                //MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true
                    ;
                return;
            }
        }

        public bool validar()
        {  
            foreach (Control c in this.paneltec.Controls)
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
