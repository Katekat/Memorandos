using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.ComponentModel;


namespace ws
{
    /// <summary>
    /// Summary description for svcmemos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class svcmemos : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        private static SqlConnection ObtenerConexion()
        {
            SqlConnection cnnConexion = new SqlConnection("Server=SANDRA-PC; Database=computacion;Trusted_Connection=True;");
            cnnConexion.Open();
            return cnnConexion;
        }

        [WebMethod]
        public DataTable CargarItems()
        {
            DataTable dt = new DataTable();

            SqlConnection cnnConexion = ObtenerConexion();
            string strSentenciaSQL = "select codigodpto, nombre from departamento ";

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);



            adpAdapter.Fill(dt);

            cnnConexion.Close();
            dt.TableName = "Lisdptos";
            return dt;

        }

        [WebMethod]
        public DataTable CargarTecnicos()
        {
            DataTable dt = new DataTable();

            SqlConnection cnnConexion = ObtenerConexion();
            string strSentenciaSQL = "select cedula, nombre from persona ";

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);



            adpAdapter.Fill(dt);

            cnnConexion.Close();
            dt.TableName = "ListTecnico";
            return dt;

        }

        [WebMethod]
        public void InsertarDepartamento(int codigo, string nombre, string encargado)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into departamento Values ({0}, '{1}', '{2}')";
            strSentenciaSQL = string.Format(strSentenciaSQL, codigo, nombre, encargado);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();
        }

        [WebMethod]
        public void InsertarTecnico(string pCedula, string pnombre, string pcargo)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into persona Values ('{0}', '{1}', '{2}')";
            strSentenciaSQL = string.Format(strSentenciaSQL, pCedula, pnombre, pcargo);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();
        }

        [WebMethod]
        /*
         Verifica si la cedula de unA Persona ya existe en la base de datos
         * por ende se tiene como parámetro el número de cédula del tecnico 
         * @Autor Katherine Florez
         */
        public DataSet BuscarTecnico(string pCedula)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "select * from persona where cedula='{0}' ";
            strSentenciaSQL = string.Format(strSentenciaSQL, pCedula);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);


            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        //BUSCAR DISPOSITIVO 
        [WebMethod]
        public DataSet BuscarDispositivo(int pCodigo)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "select * from dispositivo where codigoControl='{0}' ";
            strSentenciaSQL = string.Format(strSentenciaSQL, pCodigo);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }
        //BUSCAR NREVISION PARA VERIFICAR EXISTENCIA EN TABLA REVISION
        [WebMethod]
        public DataSet BuscarnRevision(int codigocontrol)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "select * from revision where codigocontrol='{0}' ";
            strSentenciaSQL = string.Format(strSentenciaSQL, codigocontrol) ;

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        ///BUSCAR DPTO POR CODIGO 
        [WebMethod]
        public DataSet BuscarDpto(int pCodigo)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "select * from departamento where codigodpto={0} ";
            strSentenciaSQL = string.Format(strSentenciaSQL, pCodigo);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);


            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }
        //BUSCAR TECNICO POR NOMBRE PARA ASIGNAR EN LA REVISION
        [WebMethod]
        public DataSet BuscarTecnico(string cedula)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "select * from persona where cedula={0} ";
            strSentenciaSQL = string.Format(strSentenciaSQL, cedula);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);


            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }
       
        [WebMethod]
        public void ActualizarDepartamento(int codigo, string nombre, string encargado)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "update departamento set nombre='{1}', encargado='{2}' where codigodpto={0} ";
            strSentenciaSQL = string.Format(strSentenciaSQL, codigo, nombre, encargado);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();
        }

        [WebMethod]
        public void ActualizarTecnico(string cedula, string nombre, string cargo)
        {
            SqlConnection ccnConexion = ObtenerConexion();
            string strSentenciaSQL = "update persona set nombre='{1}',cargo='{2}' where cedula='{0}'";
            strSentenciaSQL = string.Format(strSentenciaSQL, cedula, nombre, cargo);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, ccnConexion);
            cmdComando.ExecuteNonQuery();
            ccnConexion.Close();
        }
        [WebMethod]
        public void ActualizarDispositivo(string tipo, int codigoControl, string caracteristicas, string usuario, int coddpto)
        {
            SqlConnection ccnConexion = ObtenerConexion();
            string strSentenciaSQL = "update dispositivo set tipo='{0}',caracteristicas='{2}',usuario='{3}',coddpto='{4}' where codigoControl='{1}'";
            strSentenciaSQL = string.Format(strSentenciaSQL, tipo, codigoControl, caracteristicas,usuario, coddpto);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, ccnConexion);
            cmdComando.ExecuteNonQuery();
            ccnConexion.Close();
        }
        [WebMethod]
        public void ActualizarMemo(int nmemo, DateTime fecha, string descripcion, string remitente, string destinatario, string motivo)
        {
            SqlConnection ccnConexion = ObtenerConexion();
            string strSentenciaSQL = "update memos set fecha='{1}',descripcion='{2}',remitente='{3}',destinatario='{4}',motivo='{5}' where nmemo='{0}'";
            strSentenciaSQL = string.Format(strSentenciaSQL, strSentenciaSQL, nmemo, fecha, descripcion, remitente, destinatario, motivo);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, ccnConexion);
            cmdComando.ExecuteNonQuery();
            ccnConexion.Close();
           
        }
        [WebMethod]
        public void ActualizarRevision(int nrevision, int codigocontrol, int coddpto, string Dinicial, string Dfinal, string recomendaciones, string status, DateTime fecha, string recibe)
        {
            SqlConnection ccnConexion = ObtenerConexion();
            string strSentenciaSQL = "update revision set codigocontrol='{1}',coddpto='{2}',Dinicial='{3}',Dfinal='{4}',recomendaciones='{5}',status='{6}',fecha='{7}',recibe='{5}' where nrevision='{0}'";
            strSentenciaSQL = string.Format(strSentenciaSQL, nrevision, codigocontrol, coddpto, Dinicial, Dfinal, recomendaciones, status, fecha, recibe);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, ccnConexion);
            cmdComando.ExecuteNonQuery();
            ccnConexion.Close();

        }
        [WebMethod]

        public void InsertarDispositivo(string tipo, int codigoControl, string caracteristicas, string usuario, int coddpto)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into dispositivo Values ('{0}',{1},'{2},'{3},{4})";
            strSentenciaSQL = string.Format(strSentenciaSQL, tipo, codigoControl, caracteristicas,usuario,coddpto);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();
        }

      [WebMethod]
        public void InsertarMemo(int nmemo, DateTime fecha, string descripcion, string remitente, string destinatario, string motivo)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into memos Values ('{0}','{1}',{2},'{3},'{4},'{5}')";
            strSentenciaSQL = string.Format(strSentenciaSQL,nmemo, fecha, descripcion,remitente, destinatario, motivo);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();


        }
      [WebMethod]
       public void InsertarRevision (int nrevision, int codigocontrol , int coddpto, string Dinicial, string Dfinal, string recomendaciones,string status,DateTime fechaI, string recibe,DateTime fechaF )
      {
          SqlConnection cnnConexion = ObtenerConexion();

          string strSentenciaSQL = "insert into revision Values ('{0}','{1}',{2},'{3},'{4},'{5}','{6}','{7}','{8}','{9}')";
          strSentenciaSQL = string.Format(strSentenciaSQL, nrevision, codigocontrol, coddpto, Dinicial, Dfinal, recomendaciones,status,fechaI,recibe );

          SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

          cmdComando.ExecuteNonQuery();
          cnnConexion.Close();


      }

    }
    

}
