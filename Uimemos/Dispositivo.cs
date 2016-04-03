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
    public partial class Dispositivo : Form
    {
        Datos.cDispositivo dispo = new Datos.cDispositivo();


        private void Dispositivo_Load(object sender, EventArgs e)
        {
            cbnomdpto.DataSource = dispo.mostrarNombredp();
            cbnomdpto.DisplayMember = "nombre";
            cbnomdpto.ValueMember = "codigodpto";
            cbnomdpto.SelectedIndex = 0;


            List<citem> lista = new List<citem>();

            lista.Add(new citem("Case"));
            lista.Add(new citem("Teclado"));
            lista.Add(new citem("Mouse"));
            lista.Add(new citem("Impresora"));
            lista.Add(new citem("Fax"));


            cbTipo.DisplayMember = "Name";
            cbTipo.DataSource = lista;
            //cbTipo.SelectedIndexChanged += new System.EventHandler(this.cbTipo_SelectedIndexChanged);
            //this.cbTipo.SelectedIndexChanged += new System.EventHandler(cbTipo_SelectedIndexChanged);
            //dispo.tipo = cbTipo.Text;
            //dispo.coddpto = int.Parse(cbTipo.Text);
            //dispo.caracteristicas = txtCaracteristicas.Text;
            //dispo.codigoControl = int.Parse(txtCodigocontrol.Text);
            //dispo.usuario = txtNomuser.Text;
        }


        public Dispositivo()
        {

            InitializeComponent();
            timer1.Enabled = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        // SECCION DE VENTANAS 
        //INICIO
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tecnico abrir = new tecnico();
            this.Hide();
            abrir.Show();

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
        private void Departamento_Click(object sender, EventArgs e)
        {
            departamento dpto = new departamento();

            this.Hide();
            dpto.Show();
        }
        private void toolmemorando_Click(object sender, EventArgs e)
        {
            Memos memorandos = new Memos();
            this.Hide();
            memorandos.Show();
        }

        //FIN DE la sección  Ventana


        /// BUSCAR DISPOSITIVO 
        private void txtCodigocontrol_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                dispo = dispo.BuscarDispositivo(int.Parse(txtCodigocontrol.Text));
                

                if (dispo.codigoControl.ToString() != null)
                {

                    MessageBox.Show("DISPOSITIVO YA EXISTE", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (dispo.codigoControl == 0)
                {
                    txtCodigocontrol.Clear();
                    txtCodigocontrol.ReadOnly = false;
                    MessageBox.Show("DISPOSITIVO NO REGISTRADO", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        public void limpiar()
        {
            foreach (Control ctrl in this.paneldispo.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = String.Empty;

                }
            }
        }
        public bool validar_dispositivo()
        {
            dispo.BuscarDispositivo(int.Parse(txtCodigocontrol.Text));
            if (dispo.coddpto == int.Parse(txtCodigocontrol.Text))
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
            foreach (Control c in this.paneldispo.Controls)
            {
                if (c is TextBox & c.Text == String.Empty)
                {
                    return true;
                }
            }
            return false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validar_dispositivo() == false)
            {
                if (validar() == false)
                {
                    {
                        dispo.codigoControl = int.Parse(txtCodigocontrol.Text);
                        dispo.Nomdpto = cbnomdpto.SelectedValue.ToString();
                        dispo.coddpto = int.Parse(dispo.Nomdpto);
                        dispo.tipo = cbTipo.SelectedValue.ToString();
                        dispo.caracteristicas = txtCaracteristicas.Text;
                        dispo.usuario = txtNomuser.Text;
                        dispo.InsertarEnBaseDatos(dispo.tipo,  dispo.codigoControl,  dispo.caracteristicas, dispo.usuario, dispo.coddpto);
                        MessageBox.Show("Se ha insertado con éxito", "Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //limpiar();
                    }
                }}
            else
            {
                if ((txtCaracteristicas.Text != dispo.caracteristicas || txtNomuser.Text!=dispo.usuario))
                {
                    DialogResult resul = MessageBox.Show("¿Desea Cambiar los datos del dispositivo?", "Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resul == DialogResult.Yes)
                    {
                        if (validar() == false)
                        {
                            dispo.caracteristicas = txtCaracteristicas.Text;
                            dispo.usuario = txtNomuser.Text;
                            dispo.ActualizarDispositivo(dispo);
                            MessageBox.Show("Se han actualizado los datos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtCodigocontrol.ReadOnly = false;
                            //limpiar();
                        }
                        else { MessageBox.Show("Debe llenar los campos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                    }
                    else
                    {
                        txtCaracteristicas.Text = dispo.caracteristicas;
                        txtNomuser.Text = dispo.usuario;
                    }
                }
                else
                {
                    MessageBox.Show(" El dispositivo ya se encuentra registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        private void txtNomuser_KeyPress(object sender, KeyPressEventArgs e)
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












        
        
    

    
    
    
