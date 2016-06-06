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
        Datos.cDepartamento dpto = new Datos.cDepartamento();
        public frmDispDpto()
        {
            InitializeComponent();
        }

        private void frmDispDpto_Load(object sender, EventArgs e)
        {
            listado.DataSource = dispo.listadodispdpto();
            listado.DataMember="consulta";
        }

        private void txtnomDpto_KeyUp(object sender, KeyEventArgs e)
        {
            dpto.nombre = e.KeyCode.ToString();
            listado.DataSource = dpto.obtnerfiltronombre(dpto);
            listado.DataMember = "consulta";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dpto.nombre = txtnomDpto.Text;
            listado.DataSource = dpto.obtnerfiltronombre(dpto);
            listado.DataMember = "consulta";
        }

       
    }
}
