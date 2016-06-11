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
    public partial class ultimaRev : Form
    {
        public ultimaRev()
        {
            Datos.cRevision rev = new Datos.cRevision();
            InitializeComponent();
            InitializeComponent();
            DGVRevision.DataSource = null;
            DGVRevision.DataSource = rev.ObtenerRev();
            DGVRevision.DataMember = "consulta";
            DGVRevision.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void ultimaRev_Load(object sender, EventArgs e)
        {

        }


    }
}
