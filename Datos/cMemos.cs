using Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;



namespace Datos
{
   public class cMemos
    {
        public int nmemo;
        public string fecha;
        public string descripcion;
        public string remitente;
        public string destinatario;
        public string motivo;
       
      
        Datos.cBaseDatos servicio = new Datos.cBaseDatos();
        public void InsertarEnBaseDatos(cMemos memorando)
        {
            servicio.InsertarMemo( memorando.nmemo, memorando.fecha, memorando.descripcion, memorando.remitente, memorando.destinatario, memorando.motivo);
        }
         public static void insertar(cMemos memorando) {
            cMemos memo = new cMemos();
            memo.InsertarEnBaseDatos(memorando);
        }

         public cMemos obtnum()
         {
             cMemos memos = new cMemos();
             DataSet dsresultado = servicio.obtmemos();

             if (dsresultado.Tables[0].Rows.Count != 0)
             {

                 memos.nmemo = int.Parse(dsresultado.Tables[0].Rows[0]["nmemo"].ToString());
                

                 return memos;
             }
             else
             {
                 return memos;
             }

         }
      
       
    }
      
      
}



