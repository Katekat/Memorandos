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
    public partial class frmRlisttecnico : Form
    {
        Datos.cRevision rev = new Datos.cRevision();
        public frmRlisttecnico()
        {
            InitializeComponent();
        }

        private void frmRlisttecnico_Load(object sender, EventArgs e)
        {
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            rev.ci = txtcedula.Text;
            dataGridView1.DataSource = rev.listadRTecnico(rev);
            dataGridView1.DataMember = "consulta";
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                
                e.Handled = true
                    ;
                return;
            }
        }

        
    }
}
