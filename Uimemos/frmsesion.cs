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
    public partial class frmsesion : Form
    {
        Datos.cSesion sesion = new Datos.cSesion();
        public frmsesion()
        {
            InitializeComponent();
        }

        private void frmsesion_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            sesion = sesion.validaruse(txtusuario.Text , txtpass.Text);
            if (validar() == true)
            {
                MessageBox.Show("Debe llenar los campos", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            
            if (validaruser() == false)
            {
                this.Hide();
                Home h = new Home();
                h.Show();
            }
            else
            {
                MessageBox.Show("Error de usuario o contraseña", "Ingresar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                limpiar();
            }


        }

        public void limpiar()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;

                }
            }
        }

        public bool validaruser()
        {
            if (txtusuario.Text != sesion.usuario || txtpass.Text != sesion.pass)
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
            foreach (Control c in this.Controls)
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
