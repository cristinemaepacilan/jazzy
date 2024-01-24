using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.BusinessClass
{
    public class Transact
    {
        public int TransID { get; set; }
        public string TransCustomer { get; set; }
        public decimal AmountTendered { get; set; }
        public decimal AmountDue { get; set; }
        public decimal Change { get; set; }
        public decimal VAT { get; set; }
        public decimal Vatable { get; set; }
        public int TransNo { get; set; }
        public decimal Discount { get; set; }

    }
}
