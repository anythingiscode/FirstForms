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
            foreach(Empleado empleados in EmpleadoRepositorio.Empleados)
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

    }
}