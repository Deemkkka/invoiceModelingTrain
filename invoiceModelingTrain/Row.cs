using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invoiceModelingTrain
{
    /// <summary>
    /// Represents a row of data in a InvoiceModeling.Table
    /// </summary>
    internal class Row
    {
        /// <summary>
        /// Get or sets the Seqiential Number
        /// </summary>
        public int SequentialNumber { get; set; }
        /// <summary>
        /// Gets or sets the Description
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Gets or sets the Quantity
        /// </summary>
        public decimal Quantity { get; set; }
        /// <summary>
        /// Gets or sets the Price
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Gets or sets the Amount
        /// </summary>
        public decimal Amount { get => Quantity * Price; }
    }
}
