using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public  class cSesion
    {
       public string usuario;
       public string  pass;

       Datos.cBaseDatos servicio = new Datos.cBaseDatos();
        
       public cSesion validaruse(string usuario, string pass)
       {
           cSesion ss = new cSesion();
           DataSet dsresultado = servicio.BuscarUsuario(usuario, pass);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {

               ss.usuario = dsresultado.Tables[0].Rows[0]["usuario"].ToString();
               ss.pass = dsresultado.Tables[0].Rows[0]["pass"].ToString();

               return ss;
           }
           else
           {
               return ss;
           }
       }
   
   
   
   
   
   }
}
