using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestEventosDataGridView
{
    /* En un DataGridView queremos que al modificar los datos de la edad de una persona se modifique 
     * auto los años que le quedan para su jubilación
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InsertarDatos();
        }

        private void InsertarDatos()
        {
            int rowIndex = dataGridView1.Rows.Add();            //Nos devuelve el indice de la fila que hemos insertado
            dataGridView1.Rows[rowIndex].Cells[0].Value = "Silvia";     //Relleno las celdas de la fila rowIndex
            dataGridView1.Rows[rowIndex].Cells[1].Value = 30;
            dataGridView1.Rows[rowIndex].Cells[2].Value = 35;

            rowIndex = dataGridView1.Rows.Add();            //Nos devuelve el indice de la fila que hemos insertado
            dataGridView1.Rows[rowIndex].Cells[0].Value = "Pedro";     //Relleno las celdas de la fila rowIndex
            dataGridView1.Rows[rowIndex].Cells[1].Value = 50;
            dataGridView1.Rows[rowIndex].Cells[2].Value = 15;           
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            /* Este evento sucede cada vez que selecciono una celda. 
             * Para evitar esto y que solo se ejecute cuando modifiquemos la edad de una persona... controlo que el index de la columna sea == 1 que corresponde a la columna de "Edad"
             */
            if(e.ColumnIndex == 1)
            {
                //Confimo que el dato sea válido --> que sea un double y que esté entre 16 y 65 años
                bool isDouble = double.TryParse(e.FormattedValue.ToString(), out double resultadoNumerico);
                if (isDouble)
                {
                    if(resultadoNumerico < 16 || resultadoNumerico > 65)
                    {
                        dataGridView1.CancelEdit();     //Este metodo cancela la modificación del dato introducido, con lo que restaura el que estubiese antes
                        e.Cancel = true;
                        MessageBox.Show("La edad debe estar entre 16 y 65 años");
                    }

                }
                else
                {
                    dataGridView1.CancelEdit();     //Este metodo cancela la modificación del dato introducido, con lo que restaura el que estubiese antes
                    e.Cancel = true;    //Esto mantiene el foco en la celda seleccionada
                    MessageBox.Show("El dato introducido debe ser numérico");
                }
            }
            

        }

        /* Este vento se ejecuta cuando se valida el dato de la celda*/
        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 1)
            {
                double nuevaEdad = Convert.ToDouble(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value);
                double añosRestantes = 65 - nuevaEdad;
                dataGridView1.Rows[e.RowIndex].Cells[2].Value = añosRestantes;

            }
        }
    }
}
