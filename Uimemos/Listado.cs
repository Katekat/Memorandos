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
    public partial class Listado : Form
    {
        Datos.cDispositivo dispo = new Datos.cDispositivo();
        public Listado()
        {
            InitializeComponent();
        }

        private void FrmRptdispo_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dispo.obtnerlistadoinicial();
            dataGridView1.DataMember = "consulta";
        }
   
           
        //Buscar un mejor evento para manejar el filtro
        

        private void txtbusqueda_KeyUp(object sender, KeyEventArgs e)
        {
            dispo.usuario = e.KeyCode.ToString();
            dataGridView1.DataSource = dispo.obtnerlistad(dispo);
            dataGridView1.DataMember = "consulta";
        }
        

        
    }
}
