using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bikes_MS_.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public string Person { get; set; }
        public string Adress { get; set; }
        public DateTime data { get; set; }
    }
}