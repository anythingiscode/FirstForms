using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColPersoDataGridView
{
    /* Esta será la clase que represente nuestra col perso 
     * Debemos declararla como "public"
     */

    public class NotaExamenCell : DataGridViewTextBoxCell       // tenemos que heredar de "DataGridViewTextBoxCell" que es laclase que ctrla 
    {
        // Tenemos que sobreescribir el mét "paint" de "DataGridViewTextBoxCell" que es quien ctrla el aspecto de la celda
        protected override void Paint(
            Graphics graphics,
            Rectangle clipBounds,
            Rectangle cellBounds,
            int rowIndex,
            DataGridViewElementStates cellState,
            object value,
            object formattedValue,
            string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {       // 1º Para que no se vean los num de las notas pasamos "formattedValue" --> ""                
            base.Paint(graphics, clipBounds, cellBounds, rowIndex, cellState, value,
                       "",                                      
                       errorText, cellStyle, advancedBorderStyle, paintParts);
                // 2º Dibujamos un rectángulo rojo hasta la mitad de la celda
                graphics.FillRectangle(new SolidBrush(Color.Red), new Rectangle(cellBounds.X, cellBounds.Y + 10, cellBounds.Width / 2, cellBounds.Height / 4));
            // 3º Dibujamos un rectángulo verde en la otra mitad de la celda
            graphics.FillRectangle(new SolidBrush(Color.Green), new Rectangle(cellBounds.X + cellBounds.Width / 2, cellBounds.Y + 10, cellBounds.Width / 2, cellBounds.Height / 4));
            
            //4º posicionamos la barrita negra que marcará la nota
            int puntoNota = Convert.ToInt32(Convert.ToDouble(value) / 10 * cellBounds.Width);
            //5º Dibujamos la barrita negra
            graphics.FillRectangle(new SolidBrush(Color.Black), new Rectangle(cellBounds.X + puntoNota - 2, cellBounds.Y + 3, 4, 19));
        }

    }
                                    
}
