
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
using System.Diagnostics;

namespace Uimemos
{
    public partial class Revision : Form
    {
        Datos.cRevision rev = new Datos.cRevision();
        Datos.cDispositivo dispo = new Datos.cDispositivo();


        private void Revision_Load_1(object sender, EventArgs e)
        {
            txtdiagfinal.Visible = false;
            label6.Visible = false;
            txtrecomendaciones.Visible = false;
            label7.Visible = false;
            label11.Visible = false;
            fechasalida.Visible = false;
            ;
            ((ListBox)checkedListBox1).DataSource = rev.mostrarNombreTec(); ;
            ((ListBox)checkedListBox1).DisplayMember = "nombre";
            ((ListBox)checkedListBox1).ValueMember = "cedula";
          
            List<citem> lista = new List<citem>();

           
            lista.Add(new citem("En revision"));
            lista.Add(new citem("Revisado"));
            lista.Add(new citem("Entregado"));



            cbstatus.DisplayMember = "Name";
            cbstatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cbnomdpto.DropDownStyle = ComboBoxStyle.DropDownList;
            cbstatus.DataSource = lista;


            List<citem> lista2 = new List<citem>();

            lista2.Add(new citem("Case"));
            lista2.Add(new citem("Teclado"));
            lista2.Add(new citem("Mouse"));
            lista2.Add(new citem("Impresora"));
            lista2.Add(new citem("Fax"));


            cbTipo.DisplayMember = "Name";
            cbTipo.DataSource = lista2;

            cbnomdpto.DataSource = rev.mostrarNombredp();
            cbnomdpto.DisplayMember = "nombre";
            cbnomdpto.ValueMember = "codigodpto";
            cbnomdpto.SelectedIndex = 0;
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
            Memos memorando = new Memos();
            this.Hide();
            memorando.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
          if ((txtCodigocontrol.Text != "")|| (txtdiagnini.Text!="")||(txtCaracteristicas.Text!="")||(txtNomuser.Text!="")){
            if (validar() == false)
            {
                if (checkedListBox1.CheckedItems.Count != 0)
                {
                    if (rev.nrevision == 0)
                    {
                        if (cbstatus.SelectedValue.ToString() == "En revision")
                        {
                            rev.fechaF = "";
                        }
                        else
                        {
                            rev.fechaF = fechasalida.Value.ToString("yyyyMMdd");
                        }

                        rev.codigocontrol = int.Parse(txtCodigocontrol.Text);
                        rev.Dinicial = txtdiagnini.Text.ToString();
                        rev.fechaI = txtFechaen.Value.ToString("yyyyMMdd");
                        rev.status = cbstatus.SelectedValue.ToString();
                        rev.Dfinal = txtdiagfinal.Text.ToString();
                        rev.recomendaciones = txtrecomendaciones.Text.ToString();
                        rev.InsertarEnBaseDatos(rev);
                        MessageBox.Show("Se ha insertado con éxito", "Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dispo = dispo.BuscarDispositivo(int.Parse(txtCodigocontrol.Text));
                        if (dispo.codigoControl.ToString() == null)
                        {
                            dispo.codigoControl = int.Parse(txtCodigocontrol.Text);
                            dispo.Nomdpto = cbnomdpto.SelectedValue.ToString();
                            dispo.coddpto = int.Parse(dispo.Nomdpto);
                            dispo.tipo = cbTipo.SelectedValue.ToString();
                            dispo.caracteristicas = txtCaracteristicas.Text;
                            dispo.usuario = txtNomuser.Text;
                            dispo.InsertarEnBaseDatos(dispo.tipo, dispo.codigoControl, dispo.caracteristicas, dispo.usuario, dispo.coddpto);

                            MessageBox.Show("Se ha insertado con éxito", "Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                    else
                    {
                        DialogResult resul = MessageBox.Show("¿Desea Cambiar los datos del dispositivo?", "Actualizacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (resul == DialogResult.Yes)
                        {
                            if (validar() == false)
                            {
                                if ((txtFechaen.Value.ToString() == fechasalida.Value.ToString() || txtFechaen.Value < fechasalida.Value))
                                {
                                    rev.Nomdpto = cbnomdpto.Text = rev.Nomdpto;
                                    rev.Dinicial = txtdiagnini.Text.ToString();
                                    rev.status = cbstatus.SelectedValue.ToString();

                                    rev.Dfinal = txtdiagfinal.Text.ToString();
                                    rev.recomendaciones = txtrecomendaciones.Text.ToString();
                                    rev.fechaI = txtFechaen.Value.ToString("yyyyMMdd");
                                    rev.fechaF = fechasalida.Value.ToString("yyyyMMdd");
                                    rev.ActualizarRevision(rev);

                                    dispo.codigoControl = int.Parse(txtCodigocontrol.Text);
                                    dispo.Nomdpto = cbnomdpto.SelectedValue.ToString();
                                    dispo.coddpto = int.Parse(dispo.Nomdpto);
                                    dispo.tipo = cbTipo.SelectedValue.ToString();
                                    dispo.caracteristicas = txtCaracteristicas.Text;
                                    dispo.usuario = txtNomuser.Text;
                                    dispo.ActualizarDispositivo(dispo);
                                    MessageBox.Show("Se han actualizado los datos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtCodigocontrol.ReadOnly = false;


                                }
                                else
                                {
                                    MessageBox.Show("La fecha de entrada no puede ser mayor a la de salida", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else { MessageBox.Show("Debe llenar los campos", "Actualización", MessageBoxButtons.OK, MessageBoxIcon.Error); }

                        }
                        else
                        {
                            limpiar();

                        }

                    }
                

                    
                    string s = "";
                    for (int x = 0; x <= checkedListBox1.CheckedItems.Count - 1; x++)
                    {
                        s = checkedListBox1.CheckedItems[x].ToString();
                        s = checkedListBox1.SelectedValue.ToString();
                        rev.cedulaT = s;
                        rev.InsertarEnBaseDatosTec(rev);
                    }
                    MessageBox.Show(s);
                }
                else
                {
                    MessageBox.Show("Al menos debe tener un técnico la revision", "Tecnico", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

          }
          else { MessageBox.Show("Los campos no pueden estar vacios", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Information); }
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

        private void cbstatus_TextChanged(object sender, EventArgs e)
        {
            if ((cbstatus.Text == "Revisado") || (cbstatus.Text == "Entregado"))
            {

                txtdiagfinal.Visible = true;
                label6.Visible = true;
                txtrecomendaciones.Visible = true;
                label7.Visible = true;
                label11.Visible = true;
                fechasalida.Visible = true;

            }
            else
            {
                if (cbstatus.Text == "En revision")
                {

                    txtdiagfinal.Visible = false;
                    label6.Visible = false;
                    txtrecomendaciones.Visible = false;
                    label7.Visible = false;
                    label11.Visible = false;
                    fechasalida.Visible = false;

                }




            }

        }

        private void txtCodigocontrol_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                rev = rev.BuscarDispo(int.Parse(txtCodigocontrol.Text));
                dispo = dispo.BuscarDispositivo(int.Parse(txtCodigocontrol.Text));
                if ((rev.codigocontrol != 0)&&(dispo.codigoControl.ToString() != null))
                {

                    txtCodigocontrol.Text = rev.codigocontrol.ToString();
                    cbnomdpto.Text = rev.Nomdpto;
                    txtdiagnini.Text = rev.Dinicial.ToString();
                    cbstatus.DisplayMember = rev.status;
                    txtdiagfinal.Text = rev.Dfinal.ToString();
                    txtrecomendaciones.Text = rev.recomendaciones;
                    txtCodigocontrol.Text = dispo.codigoControl.ToString();
                    txtNomuser.Text = dispo.usuario;
                    txtCodigocontrol.ReadOnly = false;
                    txtCaracteristicas.Text = dispo.caracteristicas;
                    cbTipo.Text = dispo.tipo;
                    cbnomdpto.Text = dispo.Nomdpto;
                }
                else
                {
                    MessageBox.Show(" El dispositivo no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ultimaRev obj = new ultimaRev();
            obj.Show();
        }

        private void txtCaracteristicas_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
