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
       

        public Dispositivo()
        {

            InitializeComponent();
            timer1.Enabled = true;
        }



        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

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


        private void BtnGuardar_Click(object sender, EventArgs e)
        {

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

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

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
            dispo.tipo = cbTipo.Text;
            dispo.coddpto = int.Parse(cbTipo.Text);
            dispo.caracteristicas = txtCaracteristicas.Text;
            dispo.codigoControl = int.Parse(txtCodigocontrol.Text);
            dispo.usuario = txtNomuser.Text;
        }
















    }
}
