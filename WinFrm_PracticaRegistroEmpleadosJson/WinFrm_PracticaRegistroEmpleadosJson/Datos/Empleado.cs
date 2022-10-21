using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFrm_PracticaRegistroEmpleadosJson.Datos
{
    public class Empleado
    {
        #region VARIABLES PRIVADAS

        private string _id = string.Empty;
        private string _nombre = string.Empty;
        private string _apellido1 = string.Empty;
        private string _apellido2 = string.Empty;
        private double _edad = 0;
        private string _email = string.Empty;

        #endregion

        #region VARIABLES PÚBLICAS

        public string Id { get => _id; private set => _id = value; }                    //Ponemos set como private
        public string Nombre { get => _nombre; private set => _nombre = value; }
        public string Apellido1 { get => _apellido1; private set => _apellido1 = value; }
        public string Apellido2 { get => _apellido2; private set => _apellido2 = value; }
        public double Edad { get => _edad; private set => _edad = value; }
        public string Email { get => _email; private set => _email = value; }

        #endregion

        #region CONSTRUCTOR

        public Empleado(string id, string nombre, string apellido1, string apellido2, double edad, string email)
        {
            Id = id;
            Nombre = nombre;
            Apellido1 = apellido1;
            Apellido2 = apellido2;
            Edad = edad;
            Email = email;
        }

        #endregion

        #region MÉTODOS PRIVADOS

        #endregion

        #region MÉTODOS PÚBLICOS

        #endregion
    }
}
