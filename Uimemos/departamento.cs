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
            if (txtNomdpto.Text != Dpto.nombre || txtEncdpto.Text != Dpto.encargado)
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
                DialogResult resul = MessageBox.Show("¿Desea Cambiar los datos del departamento/división/oficina ?", "Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(resul == DialogResult.Yes)
                {
                    Dpto.nombre = txtNomdpto.Text;
                    Dpto.encargado = txtEncdpto.Text;
                    Dpto.ActualizarDpto(Dpto);
                    MessageBox.Show("Se han actualizado los datos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigodpto.ReadOnly = false;
                    limpiar();
                }
                else
                {
                    txtEncdpto.Focus();
                }
            }
            if (validarDpto() == false)
            {
                Dpto = Dpto.BuscarDpto(int.Parse(txtCodigodpto.Text));
                if (Dpto.codigo.ToString().Equals(txtCodigodpto.Text))
                {
                    MessageBox.Show(" El departamento/división/oficina ya esta registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {
                    Dpto.codigo = int.Parse(txtCodigodpto.Text);
                    Dpto.nombre = txtNomdpto.Text;
                    Dpto.encargado = txtEncdpto.Text;
                    Dpto.InsertarEnBaseDatos(Dpto);
                    MessageBox.Show("Inserto con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
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
    }
}
