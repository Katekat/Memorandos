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
    public partial class frmRfecha : Form
    {
        Datos.cRevision rev = new Datos.cRevision();
        public frmRfecha()
        {
            InitializeComponent();
        }

        private void frmRfecha_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rev.fechaI = dateTimePicker1.Text;
            dataGridView1.DataSource = rev.listadRfecha(rev);
            dataGridView1.DataMember = "consulta";

            
        }
    }
}
