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
   public  class cRevision
    {
       public int nrevision;
       public int codigocontrol;
       public int coddpto;
       public string Dinicial;
       public string Dfinal;
       public string recomendaciones;
       public string status;
       public string fechaI;
       public string fechaF;
       public string recibe;
       public string Nomdpto;

       Datos.cBaseDatos servicio = new Datos.cBaseDatos();
       
       public void InsertarEnBaseDatos(cRevision rev)
       {
           servicio.InsertarRevision(rev.nrevision, rev.codigocontrol, rev.coddpto, rev.Dinicial, rev.Dfinal, rev.recomendaciones,rev.status, rev.fechaI, rev.recibe, rev.fechaF);
       }
       public static void insertar(cRevision revision)
       {
           cRevision rev = new cRevision();
           rev.InsertarEnBaseDatos(rev);
       }

       public DataTable mostrarNombredp()
       {
           return servicio.CargarItems();
       }
       public DataTable mostrarNombreTec()
       {
           return servicio.CargarTecnicos();
       }

       public cRevision BuscarDpto(int coddpto)
       {

           cRevision rev = new cRevision();
           DataSet dsresultado = servicio.BuscarDpto(coddpto);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {

               rev.Nomdpto = dsresultado.Tables[0].Rows[0]["nombre"].ToString();


               return rev;
           }
           else
           {
               return rev;
           }
       }
       public cRevision BuscarCedula(string cedula)
       {

           cRevision rev = new cRevision();
           DataSet dsresultado = servicio.BuscarTecnico(cedula);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {

               rev.Nomdpto = dsresultado.Tables[0].Rows[0]["nombre"].ToString();


               return rev;
           }
           else
           {
               return rev;
           }
       }
       //VALIDACION DE SI LA REVISION EXISTE O NO
       public cRevision BuscarnRevision(int codigocontrol)
       {
           cRevision rev = new cRevision();

           DataSet dsresultado = servicio.BuscarnRevision(codigocontrol);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {
               rev.codigocontrol = int.Parse(dsresultado.Tables[0].Rows[0]["codigocontrol"].ToString());
               
               return rev;
           }
           else
           {
               return rev;
           }

       }
       public void ActualizarRevision(cRevision rev)
        {
            servicio.ActualizarRevision(rev.nrevision, rev.codigocontrol, rev.coddpto, rev.Dinicial, rev.Dfinal, rev.recomendaciones,rev.status, rev.fechaI, rev.recibe, rev.fechaF);

        }

 }
}

