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
        cDispositivo disp = new cDispositivo();

       public DataTable  mostrarNombredp()
        {
            return servicio.CargarItems();
        }

       public cDispositivo BuscarDispositivo(int codigoControl)
       {
           DataSet dsresultado = servicio.BuscarDispositivo(codigoControl);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {

               disp.codigoControl = int.Parse(dsresultado.Tables[0].Rows[0]["codigoControl"].ToString());
               disp.tipo = dsresultado.Tables[0].Rows[0]["Tipo"].ToString();
               disp.caracteristicas = dsresultado.Tables[0].Rows[0]["caracteristicas"].ToString();
               disp.coddpto = int.Parse(dsresultado.Tables[0].Rows[0]["coddpto"].ToString());
               disp.usuario = dsresultado.Tables[0].Rows[0]["usuario"].ToString();
               return disp;
           }
           else
           {
               return disp;
           }
           
       }

       public cDispositivo BuscarDpto(int coddpto)
       {
           

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
