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
    public partial class departamento : Form
    {
        public departamento()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        Datos.cDepartamento Dpto = new Datos.cDepartamento();

        private void departamento_Load(object sender, EventArgs e)
        {

        }

        private void txtCodigodpto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                Dpto = Dpto.BuscarDpto(int.Parse(txtCodigodpto.Text));


                if (Dpto.codigo.ToString() != null )
                {
                    txtCodigodpto.Text = Dpto.codigo.ToString();
                    txtNomdpto.Text = Dpto.nombre;
                    txtEncdpto.Text = Dpto.encargado;
                    txtCodigodpto.ReadOnly = Enabled;

                }
                if(Dpto.codigo ==0)
                {
                    txtCodigodpto.Clear();
                    txtCodigodpto.ReadOnly = false;
                    MessageBox.Show("DEPARTAMENTO/DIVISIÓ/OFICINA NO REGISTRADO", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }

            }

        }

        public bool validarDpto()
        {
            if ((int.Parse(txtCodigodpto.Text)!= Dpto.codigo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (validarDpto() == true)
            {
                if (validar() == false)
                {
                    Dpto.codigo = int.Parse(txtCodigodpto.Text);
                    Dpto.nombre = txtNomdpto.Text;
                    Dpto.encargado = txtEncdpto.Text;
                    Dpto.InsertarEnBaseDatos(Dpto);
                    MessageBox.Show("Inserto con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
                else{ MessageBox.Show("Debe llenar los campos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            }
            else
            {
                if ((txtNomdpto.Text != Dpto.nombre || txtEncdpto.Text != Dpto.encargado))
                {
                    DialogResult resul = MessageBox.Show("¿Desea Cambiar los datos del departamento/división/oficina ?", "Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        if (validar() == false)
                        {
                            Dpto.nombre = txtNomdpto.Text;
                            Dpto.encargado = txtEncdpto.Text;
                            Dpto.ActualizarDpto(Dpto);
                            MessageBox.Show("Se han actualizado los datos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodigodpto.ReadOnly = false;
                            limpiar();
                        }
                        else { MessageBox.Show("Debe llenar los campos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }
                    else
                    {
                         txtNomdpto.Text=Dpto.nombre;
                         txtEncdpto.Text= Dpto.encargado;
                    }
                }else{
                    MessageBox.Show(" El departamento/división/oficina ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
        }

        
        public void limpiar()
        {
            foreach (Control ctrl in this.panelDpto.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;

                }
            }

        }

        public bool validar()
        {
            foreach (Control c in this.panelDpto.Controls)
            {
                if (c is TextBox & c.Text == String.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        

        private void toolHome_Click(object sender, EventArgs e)
        {
            Home inicio = new Home();
            this.Hide();
            inicio.Show();
        }

        private void toolDispositivo_Click(object sender, EventArgs e)
        {
            Dispositivo dispo = new Dispositivo();
            this.Hide();
            dispo.Show();
        }

        private void toolTecnico_Click(object sender, EventArgs e)
        {
            tecnico tec = new tecnico();
            this.Hide();
            tec.Show();

        }

        private void toolRevision_Click(object sender, EventArgs e)
        {
            Revision revisar = new Revision();
            this.Hide();
            revisar.Show();
        }

        private void toolMemos_Click(object sender, EventArgs e)
        {
            Memos memorandos = new Memos();
            this.Hide();
            memorandos.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        private void txtCodigodpto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtNomdpto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtEncdpto_KeyPress(object sender, KeyPressEventArgs e)
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
