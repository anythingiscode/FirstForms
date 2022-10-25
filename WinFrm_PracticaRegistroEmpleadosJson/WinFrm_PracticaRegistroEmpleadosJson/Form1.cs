using System.DirectoryServices.ActiveDirectory;
using WinFrm_PracticaRegistroEmpleadosJson.Datos;
using WinFrm_PracticaRegistroEmpleadosJson.Formularios;


namespace WinFrm_PracticaRegistroEmpleadosJson
{
    public partial class frmEmpleados : Form
    {
        public frmEmpleados()
        {
            InitializeComponent();
            EmpleadoRepositorio.InicializarRepositorio();

            VisualizarEmpleados();
        }
        private void VisualizarEmpleados()
        {
            dgvEmpleados.Rows.Clear();  //Cada vez que carguemos 1º borramos lo que había para que no de sume lo mostrado anteriormente a lo nuevo que se muestra
            foreach (Empleado empleados in EmpleadoRepositorio.Empleados)
            {
                int rowIndex = dgvEmpleados.Rows.Add();
                dgvEmpleados.Rows[rowIndex].Cells[0].Value = empleados.Id.ToString();
                dgvEmpleados.Rows[rowIndex].Cells[1].Value = empleados.Nombre.ToString();
                dgvEmpleados.Rows[rowIndex].Cells[2].Value = empleados.Apellido1.ToString();
                dgvEmpleados.Rows[rowIndex].Cells[3].Value = empleados.Apellido2.ToString();
                dgvEmpleados.Rows[rowIndex].Cells[4].Value = empleados.Edad.ToString();
                dgvEmpleados.Rows[rowIndex].Cells[5].Value = empleados.Email.ToString();

            }
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            EmpleadoFrom empleadoFrom = new EmpleadoFrom();             //Creo el obj formEmpleado
            DialogResult dialogResult = empleadoFrom.ShowDialog();      //Lo muestro. Será Bloqueante mientras no se cierra
            if(dialogResult == DialogResult.OK)
            {
                EmpleadoRepositorio.AñadirEmpleado(empleadoFrom.Empleado);
                VisualizarEmpleados();
            }
        }

        private void picRemouve_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)    //Compruebo que haya al menos 1 fila seleccionada
            {
                string IdEmpleadoABorrar = dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString();  //Cells es la columna que la 1º es el Id y la 1º col =0
                EmpleadoRepositorio.EliminarEmpleado(IdEmpleadoABorrar);
                VisualizarEmpleados();
            }
            else
            {
                MessageBox.Show("Error !, Seleccione un empleado para poder eliminarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void picModif_Click(object sender, EventArgs e)
        {
            if (dgvEmpleados.SelectedRows.Count > 0)    //Compruebo que haya al menos 1 fila seleccionada
            {
                string IdEmpleadoModif= dgvEmpleados.SelectedRows[0].Cells[0].Value.ToString();  //Cells es la columna que la 1º es el Id y la 1º col =0
                string NombreEmpleadoModif = dgvEmpleados.SelectedRows[0].Cells[1].Value.ToString();
                string Apellido1EmpleadoModif = dgvEmpleados.SelectedRows[0].Cells[2].Value.ToString();
                string Apellido2EmpleadoModif = dgvEmpleados.SelectedRows[0].Cells[3].Value.ToString();
                double EdadEmpleadoModif = Convert.ToDouble(dgvEmpleados.SelectedRows[0].Cells[4].Value);
                string EmailEmpleadoModif = dgvEmpleados.SelectedRows[0].Cells[5].Value.ToString();
                //Una vez cargados en var los datos del empleado a modif, creo el obj Empleado que tendré que pasar al constructor del formEmpleado para cargar los datos
                Empleado empModif = new Empleado(IdEmpleadoModif, NombreEmpleadoModif, Apellido1EmpleadoModif, Apellido2EmpleadoModif, EdadEmpleadoModif, EmailEmpleadoModif);
                EmpleadoFrom empleadofrom = new EmpleadoFrom(empModif);
                DialogResult dialogResult = empleadofrom.ShowDialog();  //Guardo el resultado del dialog en var
                if(dialogResult == DialogResult.OK)  //Si es OK
                {
                    //Cargo los datos del empleado modif en el repositorio
                    EmpleadoRepositorio.ActualizarEmpleado(IdEmpleadoModif, empleadofrom.Empleado); //empleadofrom.Empleado: porque los datos modif estan en el formulario
                    VisualizarEmpleados();
                }      
            }
            else
            {
                MessageBox.Show("Error !, Seleccione un empleado para poder modificarlo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}