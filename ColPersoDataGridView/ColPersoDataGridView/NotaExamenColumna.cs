using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColPersoDataGridView
{
    public class NotaExamenColumna : DataGridViewColumn
    {
        public NotaExamenColumna()
        {
            CellTemplate = new NotaExamenCell();
        }
    }
}
