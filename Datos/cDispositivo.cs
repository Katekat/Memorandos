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
        public string Nomdpto;

        Rsvcmemos.svcmemos servicio = new Rsvcmemos.svcmemos();
        

       public DataTable  mostrarNombredp()
        {
            return servicio.CargarItems();
        }

       public cDispositivo BuscarDispositivo(int codigoControl)
       {
           cDispositivo disp = new cDispositivo();
           DataSet dsresultado = servicio.BuscarDispositivo(codigoControl);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {

               disp.codigoControl = int.Parse(dsresultado.Tables[0].Rows[0]["codigoControl"].ToString());
             
               return disp;
           }
           else
           {
               return disp;
           }
           
       }

       public cDispositivo BuscarDpto(int coddpto)
       {

           cDispositivo disp = new cDispositivo();
           DataSet dsresultado = servicio.BuscarDpto(coddpto);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {


               disp.Nomdpto = dsresultado.Tables[0].Rows[0]["nombre"].ToString();


               return disp;
           }
           else
           {
               return disp;
           }


       }
    }
}
