﻿using Datos;
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
        cDepartamento dpto = new cDepartamento();

        Datos.cBaseDatos servicio = new Datos.cBaseDatos();
        

       public DataTable  mostrarNombredp()
        {
            return servicio.CargarItems();
        }


       public DataSet obtnerlistad()
       {
           return servicio.ObtenerDispo();

       }

       public cDispositivo BuscarDispositivo(int codigoControl)
       {
           cDispositivo disp = new cDispositivo();
           DataSet dsresultado = servicio.BuscarDispositivo(codigoControl);

           if (dsresultado.Tables[0].Rows.Count != 0)
           {

               disp.codigoControl = int.Parse(dsresultado.Tables[0].Rows[0]["codigoControl"].ToString());
             
               return disp;
           }
           else
           {
               return disp;
           }
           
       }

       public cDispositivo BuscarDpto(int coddpto)
       {

           cDispositivo disp = new cDispositivo();
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
       public void InsertarEnBaseDatos(string tipo,  int codigoControl,  string caracteristicas, string usuario, int coddpto)
        {
            servicio.InsertarDispositivo(tipo,codigoControl,caracteristicas,usuario,coddpto);
           
        }
        public static void insertar(cDispositivo dispositivo)
       {
           cDispositivo dispo = new cDispositivo();
           dispo.InsertarEnBaseDatos(dispo.tipo, dispo.codigoControl, dispo.caracteristicas, dispo.usuario, dispo.coddpto);
       }
        public void ActualizarDispositivo(cDispositivo dispo)
        {
            servicio.ActualizarDispositivo(dispo.tipo, dispo.codigoControl, dispo.caracteristicas, dispo.usuario, dispo.coddpto);

        }
        


       }
    }

