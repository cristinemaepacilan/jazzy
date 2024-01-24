using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.BusinessClass
{
    public class ServicePackage
    {
        public int PackageID { get; set; }
        public string PackageName { get; set; }
        public string Service1 { get; set; }
        public string Service2 { get; set; }
        public string Service3 { get; set; }
        public string Service4 { get; set; }
        public string Service5 { get; set; }
        public string PackageLeadTime { get; set; }
        public decimal PackagePrice { get; set; }
    }
}
