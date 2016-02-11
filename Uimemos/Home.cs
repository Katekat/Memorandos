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

       
     
        
    }
}
