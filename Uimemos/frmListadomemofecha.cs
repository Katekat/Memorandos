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
            if (Fdesde.Value <= Fhasta.Value)
            {

                dataGridView1.DataSource = memo.listadfecha(Fdesde.Text, Fhasta.Text);
                dataGridView1.DataMember = "consulta";

                if (dataGridView1.DataSource.Equals(null))
                {
                    MessageBox.Show("No se ha encontrado ningún memo en estas fechas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 

            }
            else
            {
                MessageBox.Show("La fecha final, debe ser mayor a la inicial",  "Aviso" , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            
        }
    }
}
