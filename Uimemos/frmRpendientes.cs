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
    public partial class frmRpendientes : Form
    {
        Datos.cRevision rev = new Datos.cRevision();
        public frmRpendientes()
        {
            InitializeComponent();
        }

        private void frmRpendientes_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = rev.listadRPendiente();
            dataGridView1.DataMember = "consulta";
        }
    }
}
