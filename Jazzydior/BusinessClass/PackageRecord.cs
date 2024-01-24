using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.BusinessClass
{
    public class PackageRecord
    {
        public int Package_ID { get; set; }
        public string Package_Name { get; set; }
        public string Service_1 { get; set; }
        public string Service_2 { get; set; }
        public string Service_3 { get; set; }
        public string Service_4 { get; set; }
        public string Service_5 { get; set; }
        public string Package_LeadTime { get; set; }
        public decimal Package_Price { get; set; }
    }
}
