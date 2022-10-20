using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColPersoDataGridView
{
    internal class Alumno
    {
        #region VARIABLES PRIVADAS

        private int _id = 0;
        private string _nombre = string.Empty;
        private string _apellido = string.Empty;
        private int _NotaExamen = 0;

        #endregion

        #region VARIABLES PÚBLICAS

        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Apellido { get => _apellido; set => _apellido = value; }
        public int NotaExamen { get => _NotaExamen; set => _NotaExamen = value; }

        #endregion

        #region CONSTRUCTOR

        public Alumno() { }

        public Alumno(int id, string nombre, string apellido, int notaExamen)
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
            NotaExamen = notaExamen;
        }

        #endregion

        #region MÉTODOS PRIVADOS

        #endregion

        #region MÉTODOS PÚBLICOS

        #endregion
    }
}
