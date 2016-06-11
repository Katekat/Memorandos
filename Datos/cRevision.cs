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
       public string ci;
       public string cedulaT;

       Datos.cBaseDatos servicio = new Datos.cBaseDatos();

       public void InsertarEnBaseDatos(cRevision rev)
       {
           servicio.InsertarRevision(rev.codigocontrol, rev.coddpto, rev.Dinicial, rev.Dfinal, rev.recomendaciones, rev.status, rev.fechaI, rev.recibe, rev.fechaF);
       }
       public static void insertar(cRevision revision)
       {
           cRevision rev = new cRevision();
           rev.InsertarEnBaseDatos(rev);
       }
       public void InsertarEnBaseDatosTec(cRevision rev)
       {
           if (rev.nrevision == 0)
           {
               servicio.InsertarControlRevisiones(rev.nrevision, rev.fechaI, rev.cedulaT);
           }


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
       public cRevision BuscarDispo(int codigocontrol)
       {
           cRevision rev = new cRevision();

           DataSet dsresultado = servicio.BuscarDispo(codigocontrol);


           if (dsresultado.Tables[0].Rows.Count != null)
           {
               rev.nrevision = dsresultado.Tables[0].Rows[0]["nrevision"].ToString() != "" ? int.Parse(dsresultado.Tables[0].Rows[0]["nrevision"].ToString()) : 0;
               rev.Dfinal = dsresultado.Tables[0].Rows[0]["Dfinal"].ToString() != "" ? dsresultado.Tables[0].Rows[0]["Dfinal"].ToString() : "";
               rev.codigocontrol = int.Parse(dsresultado.Tables[0].Rows[0]["codigocontrol"].ToString());
               rev.coddpto = int.Parse(dsresultado.Tables[0].Rows[0]["codigodpto"].ToString());
               rev.Nomdpto = dsresultado.Tables[0].Rows[0]["nombre"].ToString();
               rev.Dinicial = dsresultado.Tables[0].Rows[0]["Dinicial"].ToString();
               rev.fechaI = dsresultado.Tables[0].Rows[0]["fecha"].ToString();
               rev.fechaF = dsresultado.Tables[0].Rows[0]["fechasalida"].ToString() != "" ? dsresultado.Tables[0].Rows[0]["Dfinal"].ToString() : "";
               rev.recomendaciones = dsresultado.Tables[0].Rows[0]["recomendaciones"].ToString() != "" ? dsresultado.Tables[0].Rows[0]["recomendaciones"].ToString() : "";
               rev.recibe = dsresultado.Tables[0].Rows[0]["recibe"].ToString() != "" ? dsresultado.Tables[0].Rows[0]["recibe"].ToString() : "";
               rev.status = dsresultado.Tables[0].Rows[0]["estatus"].ToString();
               return rev;
           }
           else
           {
               return rev;
           }

       }

       public DataSet listadRfecha(cRevision rev)
       {
           return servicio.ListRfecha(rev.fechaI);
       }

       public DataSet listadRTecnico(cRevision rev)
       {
           return servicio.ListRtecnico(rev.ci);
       }

       public DataSet listadRPendiente(cRevision rev)
       {
           return servicio.ListRpendiente(rev.status);
       }

       public DataSet listadoRevisión()
       {
           return servicio.listadoRevision();
       }

       public DataSet TotalReparado()
       {
           
           return servicio.Cantidadreparada();
       }
       public DataSet ObtenerRev()
       {
           return servicio.ObtenerRev();

       }
 }
}

