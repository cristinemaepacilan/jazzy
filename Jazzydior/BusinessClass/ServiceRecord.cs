using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jazzydior.BusinessClass
{
   public class ServiceRecord
    {
                  public int  Service_ID { get; set; }
                  public string Service_Name { get; set; }
                  public int Service_CategoryID { get; set; }
                  public string Service_CategoryName { get; set; }
                  public string Service_LeadTime { get; set; }
                  public decimal Service_Price { get; set; }
    }

}
