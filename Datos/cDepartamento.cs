using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
   public class cDepartamento
    {
       public int  codigo ;
       public string nombre ;
       public string encargado;

       Rsvcmemos.svcmemos servicio = new Rsvcmemos.svcmemos();
       public void InsertarEnBaseDatos(cDepartamento pDpto)
       {
           ///Metodo de inserciò0n
           servicio.InsertarDepartamento(pDpto.codigo, pDpto.nombre, pDpto.encargado);

       }
       public static void insertar(cDepartamento pDpto)
       {
           cDepartamento dpt = new cDepartamento();
           dpt.InsertarEnBaseDatos(pDpto);
       }

       public void ActualizarDpto(cDepartamento pDpto)
       {
           servicio.ActualizarDepartamento(pDpto.codigo, pDpto.nombre, pDpto.encargado);

       }

       public cDepartamento BuscarDpto(int codigo)
       {
           cDepartamento dpto = new cDepartamento();

           DataSet dsresultado = servicio.BuscarDpto(codigo);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {

               dpto.codigo= int.Parse(dsresultado.Tables[0].Rows[0]["codigodpto"].ToString());
               dpto.nombre = dsresultado.Tables[0].Rows[0]["nombre"].ToString();
               dpto.encargado = dsresultado.Tables[0].Rows[0]["encargado"].ToString();

               return dpto;
           }
           else
           {
               return dpto;
           }


       }
    }
}
