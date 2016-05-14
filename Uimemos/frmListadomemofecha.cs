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
    public partial class frmListadomemofecha : Form
    {
        Datos.cMemos memo = new Datos.cMemos();
        public frmListadomemofecha()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            memo.fecha = dateTimePicker1.Text;
            dataGridView1.DataSource = memo.listadfecha(memo);
            dataGridView1.DataMember = "consulta";
        }
    }
}
