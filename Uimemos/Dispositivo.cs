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

        }

        private void Dispositivo_Load(object sender, EventArgs e)
        {
            dispo.mostrarNombredp();
            var list = dispo.mostrarNombredp();
            cbnomdpto.DataSource = list;
            cbnomdpto.DisplayMember = "nombre";
            cbnomdpto.ValueMember = "codigodpto";
            
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

        

       

        

       

        
    }
}
