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
        public DateTime Date { get; init; }
        public string Number { get; init; } = null;
        public string To { get; init; } = null;
        public string From  { get; init; } = null;

        // body


        
        // footer
        public decimal Total { get; private set; }
        public string StorekeeperSurname { get; init; } = null;
        public string ForwarderSurname { get; init; } = null;
    }

}
