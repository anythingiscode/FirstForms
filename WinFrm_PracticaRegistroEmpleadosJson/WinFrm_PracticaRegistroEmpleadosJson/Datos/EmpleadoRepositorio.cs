using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace WinFrm_PracticaRegistroEmpleadosJson.Datos
{
    public class EmpleadoRepositorio
    {
        private const string RUTA_FICHERO_EMPLEADOS = @"C:\ROL\C#\Temp\jsonDeWinFrm_PracticaRegistroEmpleadosJson\Empleados.json";
        public static List<Empleado> Empleados { get; private set; }

        /* Funciones para acceder a esta lista */
        public static void InicializarRepositorio()
        {
            //una vez creamos el json. Al inicio hay que cargar el fichero con los registros ya creados
            if (File.Exists(RUTA_FICHERO_EMPLEADOS))
            {
                string json = File.ReadAllText(RUTA_FICHERO_EMPLEADOS);
                // Tengo que convertir el .json en lista empleados
                Empleados = JsonConvert.DeserializeObject<List < Empleado >> (json);
            }
            else
            {
                Empleados = new List<Empleado>();
            }
            
        }

        /*AÑADIR EMPLEADO + Crear .json*/
        public static void AñadirEmpleado(Empleado emp)
        {
            Empleados.Add(emp);
            //Aquí crearé el fichero j.son a parlis de la lista Empleado son el paquete Nuguet Newtonsoft.Json
            string json = JsonConvert.SerializeObject(Empleados,Formatting.Indented);       // 53'
            //y creo el fichero con "File"
            File.WriteAllText(RUTA_FICHERO_EMPLEADOS, json);
        }

        /*ELIMINAR EMPLEADO*/
        public static void EliminarEmpleado(string id)
        {
            if (Convert.ToInt32(id) >= 0 && Convert.ToInt32(id) <= Empleados.Count() - 1)
            {
                Empleados.RemoveAll(e => e.Id.Equals(id));
                string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);      
                File.WriteAllText(RUTA_FICHERO_EMPLEADOS, json);
            }
            else
            {
                MessageBox.Show("El id del empleado que quiere eliminar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
        }

        /*ACTUALIZAR EMPLEADO*/
        public static void ActualizarEmpleado(string idOrigen, Empleado empModif)
        {
           int indiceEmpleadoOrig = Empleados.FindIndex(e => e.Id == idOrigen);
            if (indiceEmpleadoOrig != -1)        //Localizo la fila en la que se encuentra el empleado a modificar
            {
                Empleados[indiceEmpleadoOrig] = empModif;
                string json = JsonConvert.SerializeObject(Empleados, Formatting.Indented);
                File.WriteAllText(RUTA_FICHERO_EMPLEADOS, json);
            }
            else
                MessageBox.Show("El id del empleado que quiere modificar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
       
        }
    }    
}
