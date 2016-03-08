using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

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
            SqlConnection cnnConexion = new SqlConnection("Server=KATHERINE; Database=computacion;Trusted_Connection=True;");
            cnnConexion.Open();
            return cnnConexion;
        }

        [WebMethod]
        public DataTable CargarItems()
        {
            
                SqlConnection cnnConexion = ObtenerConexion();
                string strSentenciaSQL = "select codigodpto, nombre from departamento ";

                SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

                SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

                DataTable dt = new DataTable();

                adpAdapter.Fill(dt);

                cnnConexion.Close();
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
         Verifica si la cedula de un cliente ya existe en la base de datos
         * por ende se tiene como parámetro el número de cédula del cliente 
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

    }
}
