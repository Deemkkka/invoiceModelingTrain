using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceModelingTrain
{
    internal class Table
    {

        Row[] rows = new Row[0];
        /// <summary>
        /// Gets the Size
        /// </summary>
        public int Size { get => rows.Length; }
        public decimal Total { get; private set; }

        public void AddRow(Row row)
        {
            Array.Resize(ref rows, rows.Length + 1);
            rows[rows.Length - 1] = row;
            row.SequentialNumber = rows.Length;
            Total += row.Amount;
        }

        public Row GetRow(int index)
        {
            return rows[index];
        }
    }
}
