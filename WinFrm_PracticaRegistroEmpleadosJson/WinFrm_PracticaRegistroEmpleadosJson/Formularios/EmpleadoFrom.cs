using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFrm_PracticaRegistroEmpleadosJson.Datos;

namespace WinFrm_PracticaRegistroEmpleadosJson.Formularios
{
    public partial class EmpleadoFrom : Form
    {
        public Empleado Empleado { get; private set; }

        public EmpleadoFrom()
        {
            InitializeComponent();
        }

        // Nuevo constructor para usar el mismo from de empleado para la función ModificarEmpleado
        public EmpleadoFrom(Empleado emp)       //Paso un obj Empleado "emp" que correspondrá al empleado seleccionado en la dgvEmpleados
        {
            InitializeComponent();
            txtId.Text = emp.Id;
            txtNombre.Text = emp.Nombre;
            txtApellido1.Text = emp.Apellido1;
            txtApellido2.Text = emp.Apellido2;
            txtEdad.Text = emp.Edad.ToString();
            txtEmail.Text = emp.Email;

        }
        private void EmpleadoForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(ValidarDatos(out string errorMsg))
            {
                Empleado = new Empleado(txtId.Text, txtNombre.Text, txtApellido1.Text, txtApellido2.Text, Convert.ToDouble(txtEdad.Text), txtEmail.Text);
                DialogResult = DialogResult.OK; //esta sentencia cierra el formulario y desde fuera se podrá consultar el DialogResult
            } 
            else
            {
                MessageBox.Show(errorMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DialogResult=DialogResult.Cancel;
            }
        }

        private bool ValidarDatos(out string errorMsg)
        {
            errorMsg = string.Empty;
            if (string.IsNullOrEmpty(txtId.Text))
                errorMsg += "El Id del empleado no puede estar vacio." + Environment.NewLine;
            if (string.IsNullOrEmpty(txtNombre.Text))
                errorMsg += "El Nombre del empleado no puede estar vacio." + Environment.NewLine;
            if (string.IsNullOrEmpty(txtApellido1.Text))
                errorMsg += "El Apellido del empleado no puede estar vacio." + Environment.NewLine;
            if (string.IsNullOrEmpty(txtApellido2.Text))
                errorMsg += "El apellido del empleado no puede estar vacio." + Environment.NewLine;
            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                errorMsg += "La Edad del empleado no puede estar vacia." + Environment.NewLine;
            }
            else if (double.TryParse(txtEdad.Text, out double edad))
            {
                if (edad < 16 && edad > 65) 
                    errorMsg += "La Edad del empleado situarse entre 16 y 65 años." + Environment.NewLine;
            }
            else
            {
                errorMsg += "La Edad debe ser un dato numérico" + Environment.NewLine;
            }
            try
            {
                if (string.IsNullOrEmpty(txtEmail.Text))
                {
                    errorMsg += "El Email del empleado no puede estar vacio." + Environment.NewLine;
                }
                new MailAddress(txtEmail.Text);            
            }
            catch (Exception ex)
            {
                errorMsg += "El E-mail es incorrecto." + Environment.NewLine;
            }
            return errorMsg == String.Empty;
            
                

        }
    }
}
