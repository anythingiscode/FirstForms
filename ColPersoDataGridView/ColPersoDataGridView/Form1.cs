namespace ColPersoDataGridView
{
    public partial class frmNotasAl : Form
    {
        /* En un grid de alumnos y notas de evaluaci�n, a�adir una col perso de grafico de barra horiz donde
         * situemos un puntero que marcar� la nota entre dos extremos (0 -10)
         */

        public frmNotasAl()
        {
            InitializeComponent();
        }

        public void Rellenar()
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("11111111A","Maria","Casas",7.5));
            alumnos.Add(new Alumno("22222222B", "Carlos", "Perez", 5));
            alumnos.Add(new Alumno("11111111A", "Monica", "Lezo", 4));
            alumnos.Add(new Alumno("11111111A", "Pedro", "Suarez", 8.5));

        }
    }
}