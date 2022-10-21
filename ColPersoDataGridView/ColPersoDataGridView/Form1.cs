namespace ColPersoDataGridView
{
    public partial class frmNotasAl : Form
    {
        /* En un grid de alumnos y notas de evaluación, añadir una col perso de grafico de barra horiz donde
         * situemos un puntero que marcará la nota entre dos extremos (0 -10)
         */

        public frmNotasAl()
        {
            InitializeComponent();
            Rellenar();
        }

        public void Rellenar()
        {
            List<Alumno> alumnos = new List<Alumno>();
            alumnos.Add(new Alumno("11111111A","Maria","Casas",7.5));
            alumnos.Add(new Alumno("22222222B", "Carlos", "Perez", 5));
            alumnos.Add(new Alumno("33333333C", "Monica", "Lezo", 4));
            alumnos.Add(new Alumno("44444444D", "Pedro", "Suarez", 8.5));

            foreach(Alumno alumno in alumnos)
            {
                int rowIndex = dgvNotas.Rows.Add(alumno);
                dgvNotas.Rows[rowIndex].Cells[0].Value=alumno.Id;
                dgvNotas.Rows[rowIndex].Cells[1].Value = alumno.Nombre;
                dgvNotas.Rows[rowIndex].Cells[2].Value = alumno.Apellido;
                dgvNotas.Rows[rowIndex].Cells[3].Value = alumno.NotaExamen;
                dgvNotas.Rows[rowIndex].Cells[4].Value = alumno.NotaExamen;
            }

        }
    }
}