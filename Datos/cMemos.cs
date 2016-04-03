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
            servicio.InsertarMemo(memorando.nmemo, memorando.fecha, memorando.descripcion, memorando.destinatario, memorando.motivo);
        }
         public static void insertar(cMemos memorando) {
            cMemos memo = new cMemos();
            memo.InsertarEnBaseDatos(memorando);
        }
      
       
    }
      
      
}



