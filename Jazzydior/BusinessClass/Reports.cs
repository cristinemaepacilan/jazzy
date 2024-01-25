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
        public int TransStaffID { get; set; }
        public decimal Discount { get; set; }
        public decimal TransTotalAmount { get; set; }
        public DateTime TransDate { get; set; }
        public DateTime TransTime { get; set; }
        public decimal TransAmountTendered { get; set; }
        public decimal TransAmountDue { get; set; }
        public decimal TransVATSales { get; set; }
        public decimal TransVATAmount { get; set; }

    }
}
