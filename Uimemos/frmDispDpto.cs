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
    public partial class frmDispDpto : Form
    {
        Datos.cDispositivo dispo = new Datos.cDispositivo();
        public frmDispDpto()
        {
            InitializeComponent();
        }

        private void frmDispDpto_Load(object sender, EventArgs e)
        {
            listado.DataSource = dispo.listadodispdpto();
            listado.DataMember="consulta";
        }

       
    }
}
