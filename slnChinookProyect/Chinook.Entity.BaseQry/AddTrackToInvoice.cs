using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinook.Entity.BaseQry
{
    public class AddTrackToInvoice
    {
        public int TrackId { get; set; }
        public string Name { get; set; }
        public string Composer { get; set; }
        public int Milliseconds { get; set; }
        public float UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int InvoiceLineId { get; set; }
        //var AddTrackToInvoice = new { TrackId = 0, Name = "", Composer = "", Milliseconds = 0, UnitPrice = 0.00, Quantity = 0, InvoiceLineId = 0 };
    }
}
