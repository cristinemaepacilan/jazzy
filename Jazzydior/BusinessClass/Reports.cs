using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.BusinessClass
{
    public class Reports
    {
        public int TransactionID { get; set; }
        public string TransactionNo { get; set; }
        public string CustomerName { get; set; }
        public string TransService { get; set; }
        public int TransStaffID { get; set; }
        public string Discount { get; set; }
        public string TransTotalAmount { get; set; }
        public string TransDate { get; set; }
        public string TransTime { get; set; }
        public string TransAmountTendered { get; set; }
        public string TransAmountDue { get; set; }
        public string TransVATSales { get; set; }
        public string TransVATAmount { get; set; }

    }
}
