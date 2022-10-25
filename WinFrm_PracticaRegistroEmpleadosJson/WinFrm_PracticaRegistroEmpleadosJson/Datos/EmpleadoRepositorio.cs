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
        public static List<Empleado> Empleados { get; private set; }

        /* Funciones para acceder a esta lista */
        public static void InicializarRepositorio()
        {
            Empleados = new List<Empleado>();
        }

        /*AÑADIR EMPLEADO*/
        public static void AñadirEmpleado(Empleado emp)
        {
            Empleados.Add(emp);
        }

        /*ELIMINAR EMPLEADO*/
        public static void EliminarEmpleado(string id)
        {
            if (Convert.ToInt32(id) >= 0 && Convert.ToInt32(id) <= Empleados.Count() - 1)
            {
                Empleados.RemoveAll(e => e.Id.Equals(id));
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
                Empleados[indiceEmpleadoOrig] = empModif;
            else
                MessageBox.Show("El id del empleado que quiere modificar no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand);
       
        }
    }    
}
