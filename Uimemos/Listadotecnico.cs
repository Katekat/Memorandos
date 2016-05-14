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
    public partial class Listadotecnico : Form
    {
        Datos.cTecnico tec = new Datos.cTecnico();

        public Listadotecnico()
        {
            InitializeComponent();
        }

        private void Listadotecnico_Load(object sender, EventArgs e)
        {
            listadotec.DataSource = tec.obtenertecnicos();
            listadotec.DataMember = "Consulta";
        }
    }
}
