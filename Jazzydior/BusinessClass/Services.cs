using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.BusinessClass
{
    public class Services
    {

        public int ServiceID { get; set; }
        public string ServiceName { get; set; }
        public int ServiceCategoryID { get; set; }
        public string ServiceLeadTime { get; set; }
        public decimal ServicePrice { get; set; }
    }

}
