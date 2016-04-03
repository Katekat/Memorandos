using System;
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
    public partial class FrmRptdispo : Form
    {
        Datos.cDispositivo dipo = new Datos.cDispositivo();
        public FrmRptdispo()
        {
            InitializeComponent();
        }

        private void FrmRptdispo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dipo.obtnerlistad();
            dataGridView1.DataMember = "consulta";
        }
    }
}
