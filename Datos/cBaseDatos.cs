using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.ComponentModel;
using Datos;
namespace Datos
{
    class cBaseDatos
    {


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




        public void InsertarDepartamento(int codigo, string nombre, string encargado)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into departamento Values ({0}, '{1}', '{2}')";
            strSentenciaSQL = string.Format(strSentenciaSQL, codigo, nombre, encargado);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();
        }


        public void InsertarTecnico(string pCedula, string pnombre, string pcargo, string estatus)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into persona Values ('{0}', '{1}', '{2}', '{3}')";
            strSentenciaSQL = string.Format(strSentenciaSQL, pCedula, pnombre, pcargo, estatus);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();
        }

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


        public DataSet Buscarmemo(int pnumero)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "select * from memos where nmemo='{0}' and fecha = CONVERT (date, GETDATE()) ";
            strSentenciaSQL = string.Format(strSentenciaSQL, pnumero);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);


            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        //BUSCAR DISPOSITIVO 

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

        //Obtener la cantidad de memorandos

        public DataSet obtmemos()
        {

            SqlConnection cnnConexion = ObtenerConexion();


            string strSentenciaSQL = "spmemonum";
            strSentenciaSQL = string.Format(strSentenciaSQL);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);
            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        //BUSCAR NREVISION PARA VERIFICAR EXISTENCIA EN TABLA REVISION
        public DataSet BuscarnRevision(int codigocontrol)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "select * from revision where codigocontrol='{0}' ";
            strSentenciaSQL = string.Format(strSentenciaSQL, codigocontrol);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        ///BUSCAR DPTO POR CODIGO 

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

        public DataSet BuscarUsuario(string usuario, string pass)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "select * from administrador where usuario='{0}' and pass='{1}' ";
            strSentenciaSQL = string.Format(strSentenciaSQL, usuario, pass);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);


            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }
   
        public void ActualizarDepartamento(int codigo, string nombre, string encargado)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "update departamento set nombre='{1}', encargado='{2}' where codigodpto={0} ";
            strSentenciaSQL = string.Format(strSentenciaSQL, codigo, nombre, encargado);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();
        }


        public void ActualizarTecnico(string cedula, string nombre, string cargo, string estatus)
        {
            SqlConnection ccnConexion = ObtenerConexion();
            string strSentenciaSQL = "update persona set nombre='{1}',cargo='{2}', estatus='{3}' where cedula='{0}'";
            strSentenciaSQL = string.Format(strSentenciaSQL, cedula, nombre, cargo, estatus);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, ccnConexion);
            cmdComando.ExecuteNonQuery();
            ccnConexion.Close();
        }

        public void ActualizarDispositivo(string tipo, int codigoControl, string caracteristicas, string usuario, int coddpto)
        {
            SqlConnection ccnConexion = ObtenerConexion();
            string strSentenciaSQL = "update dispositivo set tipo='{0}',caracteristicas='{2}',usuario='{3}',coddpto='{4}' where codigoControl='{1}'";
            strSentenciaSQL = string.Format(strSentenciaSQL, tipo, codigoControl, caracteristicas, usuario, coddpto);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, ccnConexion);
            cmdComando.ExecuteNonQuery();
            ccnConexion.Close();
        }

        public void ActualizarMemo(string descripcion, string destinatario, string motivo , int nmemo)
        {
            SqlConnection ccnConexion = ObtenerConexion();
            string strSentenciaSQL = "update memos set descripcion='{0}',destinatario='{1}',motivo='{2}' where nmemo='{3}'";
            strSentenciaSQL = string.Format(strSentenciaSQL, descripcion, destinatario, motivo, nmemo);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, ccnConexion);
            cmdComando.ExecuteNonQuery();
            ccnConexion.Close();

        }

        public void ActualizarRevision(int nrevision, int codigocontrol, int coddpto, string Dinicial, string Dfinal, string recomendaciones, string status, string fechaI, string recibe, string fechaF)
        {
            SqlConnection ccnConexion = ObtenerConexion();
            string strSentenciaSQL = "update revision set codigocontrol='{1}',coddpto='{2}',Dinicial='{3}',Dfinal='{4}',recomendaciones='{5}',status='{6}',fechaI='{7}',recibe='{8}',fechaF='{9}' where nrevision='{0}'";
            strSentenciaSQL = string.Format(strSentenciaSQL, nrevision, codigocontrol, coddpto, Dinicial, Dfinal, recomendaciones, status, fechaI, recibe, fechaF);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, ccnConexion);
            cmdComando.ExecuteNonQuery();
            ccnConexion.Close();

        }


        public void InsertarDispositivo(string tipo, int codigoControl, string caracteristicas, string usuario, int coddpto)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into dispositivo Values ('{0}',{1},'{2}','{3}',{4})";
            strSentenciaSQL = string.Format(strSentenciaSQL, tipo, codigoControl, caracteristicas, usuario, coddpto);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();
        }

        public void InsertarMemo(int nmemo, string fecha, string descripcion, string remitente, string destinatario, string motivo)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into memos Values ({0},'{1}','{2}',default,'{4}','{5}')";
            strSentenciaSQL = string.Format(strSentenciaSQL, nmemo, fecha, descripcion, remitente, destinatario, motivo);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();


        }

        public void InsertarRevision(int nrevision, int codigocontrol, int coddpto, string Dinicial, string Dfinal, string recomendaciones, string status, string fechaI, string recibe, string fechaF)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "insert into revision Values ('{0}','{1}',{2},'{3},'{4},'{5}','{6}','{7}','{8}','{9}')";
            strSentenciaSQL = string.Format(strSentenciaSQL, nrevision, codigocontrol, coddpto, Dinicial, Dfinal, recomendaciones, status, fechaI, recibe);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            cmdComando.ExecuteNonQuery();
            cnnConexion.Close();

        }

        public DataSet ObtenerDispo(string txtuser)
        {

            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "spFiltrarnombre";
            strSentenciaSQL = string.Format(strSentenciaSQL);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            cmdComando.Parameters.Add("@User", SqlDbType.VarChar).Value = txtuser;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        public DataSet ListMemos()
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "ListadoMemos";
            strSentenciaSQL = string.Format(strSentenciaSQL);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        public DataSet ListMemosFecha(string DesdeFecha, string HastaFecha)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "ListadoMemosFecha";
            strSentenciaSQL = string.Format(strSentenciaSQL);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            cmdComando.Parameters.Add("@fechadesde", SqlDbType.Date).Value = DesdeFecha;
            cmdComando.Parameters.Add("@fechahasta", SqlDbType.Date).Value = HastaFecha;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }


        public DataSet ListRfecha(string fecha)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "sprevisionesfecha";
            strSentenciaSQL = string.Format(strSentenciaSQL);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            cmdComando.Parameters.Add("@fecha", SqlDbType.Date).Value = fecha;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;
        }


        public DataSet ListRtecnico(string cedula)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "spTecnicorevision";
            strSentenciaSQL = string.Format(strSentenciaSQL);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            cmdComando.Parameters.Add("@cedula", SqlDbType.VarChar).Value = cedula;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;
            
        }

        public DataSet ListRpendiente(string estatus)
        {
            SqlConnection cnnConexion = ObtenerConexion();

            string strSentenciaSQL = "spRpendientes";
            strSentenciaSQL = string.Format(strSentenciaSQL);

            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            cmdComando.Parameters.Add("@estatus", SqlDbType.VarChar).Value = estatus;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }


        public DataSet ObtenerDispoinicial()
        {

            SqlConnection cnnConexion = ObtenerConexion();
            string strSentenciaSQL = "spObtenerDispositivo2";
            strSentenciaSQL = string.Format(strSentenciaSQL);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;
        }

        public DataSet listadoRevision()
        {

            SqlConnection cnnConexion = ObtenerConexion();
            string strSentenciaSQL = "select * from revision";
            strSentenciaSQL = string.Format(strSentenciaSQL);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;
        }


        public DataSet Cantidadreparada()
        {

            SqlConnection cnnConexion = ObtenerConexion();
            string strSentenciaSQL = "select count(*) As Cantidad from revision where estatus='Reparado'";
            strSentenciaSQL = string.Format(strSentenciaSQL);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);

            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;
        }

        public DataSet ObtenerDispdpto()
        {

            SqlConnection cnnConexion = ObtenerConexion();
            string strSentenciaSQL = "splistadodispdptoinicial";
            strSentenciaSQL = string.Format(strSentenciaSQL);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        public DataSet ObtenerDispdptofiltro(string nombredpto)
        {

            SqlConnection cnnConexion = ObtenerConexion();
            string strSentenciaSQL = "splistadodispdpto";
            strSentenciaSQL = string.Format(strSentenciaSQL);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            cmdComando.Parameters.Add("@nombDpto", SqlDbType.VarChar).Value = nombredpto;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

        public DataSet ObtenerTecnicos()
        {

            SqlConnection cnnConexion = ObtenerConexion();
            string strSentenciaSQL = "splistadotecnicos";
            strSentenciaSQL = string.Format(strSentenciaSQL);
            SqlCommand cmdComando = new SqlCommand(strSentenciaSQL, cnnConexion);
            cmdComando.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adpAdapter = new SqlDataAdapter(cmdComando);

            DataSet dsConsulta = new DataSet();

            adpAdapter.Fill(dsConsulta, "consulta");

            cnnConexion.Close();

            return dsConsulta;

        }

    }




}