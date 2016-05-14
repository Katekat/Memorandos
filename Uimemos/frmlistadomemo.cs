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
    public partial class frmlistadomemo : Form
    {
        Datos.cMemos memo = new Datos.cMemos();
        public frmlistadomemo()
        {
            InitializeComponent();
        }

        private void frmlistadomemo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = memo.Obtenermemos();
            dataGridView1.DataMember = "consulta";
        }
    }
}
