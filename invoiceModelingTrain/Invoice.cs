using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceModelingTrain
{
    internal class Invoice
    {
        // title
        /// <summary>
        /// Get or sets the Date
        /// </summary>
        public DateTime Date { get; init; }
        /// <summary>
        /// Get or sets the Number
        /// </summary>
        public string Number { get; init; } = null;
        /// <summary>
        /// Get or sets the To
        /// </summary>
        public string To { get; init; } = null;
        /// <summary>
        /// Get or sets the From
        /// </summary>
        public string From  { get; init; } = null;

        // body
        /// <summary>
        /// Get the Table
        /// </summary>
        public Table Table { get; } = new Table();


        // footer
        /// <summary>
        /// Get the Total
        /// </summary>
        public decimal Total { get => Table.Total; }
        /// <summary>
        /// Get or sets the StorekeeperSurname
        /// </summary>
        public string StorekeeperSurname { get; init; } = null;
        /// <summary>
        /// Get or sets the ForwarderSurname
        /// </summary>
        public string ForwarderSurname { get; init; } = null;
    }

}
