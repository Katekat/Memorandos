using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Datos
{
    public class cDispositivo{
        public string tipo;
        public int codigoControl;
        public string caracteristicas;
        public string usuario;
        public int coddpto;

        Rsvcmemos.svcmemos servicio = new Rsvcmemos.svcmemos();

       public DataTable  mostrarNombredp()
        {
            return servicio.CargarItems();
        }
    }
}
