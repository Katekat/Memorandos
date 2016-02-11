﻿using System;
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
            if (txtNombre.Text != tec.nombre || txtCargo.Text != tec.cargo)
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
                     DialogResult result=  MessageBox.Show("¿Desea Cambiar los datos del técnico?", "Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                     if (result == DialogResult.Yes)
                     {
                         tec.cargo = txtCargo.Text;
                         tec.nombre = txtNombre.Text;
                         MessageBox.Show("Se han actualizado los datos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                         txtCedula.ReadOnly = false;
                         limpiar();

                     }
            }
            if (validarTecnico() == false)
            {
                tec = tec.BuscarTecnico(txtCedula.Text);
                if (tec.cedula.Equals(txtCedula.Text))
                {
                    MessageBox.Show(" La persona ya esta registrada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else { 
                    tec.cedula = txtCedula.Text;
                    tec.nombre = txtNombre.Text;
                    tec.cargo = txtCargo.Text;
                    tec.InsertarEnBaseDatos(tec) ;
                    MessageBox.Show("Inserto con éxito", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
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
    }
}
