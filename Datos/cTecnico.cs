using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
  public  class cTecnico
    {
     public string cedula;
     public string nombre;
     public string cargo;

        
       Datos.cBaseDatos servicio= new Datos.cBaseDatos();
      
      public void InsertarEnBaseDatos(cTecnico persona)
        {
            ///Metodo de inserciò0n
           servicio.InsertarTecnico(persona.cedula, persona.nombre, persona.cargo);
           
        }
        public static void insertar(cTecnico persona) {
            cTecnico tec = new cTecnico();
            tec.InsertarEnBaseDatos(persona);
        }

        
        /* método que retorna si la cédula del tecnico ya existe en la base de datos*/
        public cTecnico BuscarTecnico(string pCedula)
        {
            cTecnico tec = new cTecnico();

            DataSet dsresultado = servicio.BuscarTecnico(pCedula);

            if (dsresultado.Tables[0].Rows.Count != 0)
            {

                tec.cedula = dsresultado.Tables[0].Rows[0]["cedula"].ToString();
                tec.nombre = dsresultado.Tables[0].Rows[0]["nombre"].ToString();
                tec.cargo = dsresultado.Tables[0].Rows[0]["cargo"].ToString();
                
                return tec;
            }
            else
            {
                return tec;
            }
           
        }

        public void actualizarTecnico(cTecnico tec)
        {
            servicio.ActualizarTecnico(tec.cedula, tec.nombre, tec.cargo);
        }
    }
       
    }


