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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            timer1.Enabled = true;
          
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Dispositivo dispositivo = new Dispositivo();
            this.Hide();
            dispositivo.Show();

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tecnico tec= new tecnico();
            this.Hide();
            tec.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            Revision revisar = new Revision();
            this.Hide();
            revisar.Show();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            departamento dpto = new departamento();
            this.Hide();
            dpto.Show();
        }

        private void Itememorando_Click(object sender, EventArgs e)
        {
            Memos memorandos = new Memos();
            this.Hide();
            memorandos.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            hora.Text = DateTime.Now.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Listado report = new Listado();
            report.Show();
        }

        private void cantidadPorDptoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDispDpto report = new frmDispDpto();
            report.Show();

        }

        private void listadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Listadotecnico report = new Listadotecnico();
            report.Show();
        }

       
     
        
    }
}
