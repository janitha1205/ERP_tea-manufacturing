using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BomAdv : BOMDTO
    {
        
        public List<int> Mechine_id { get; set; }
        public List<int> Mechine_name { get; set; }
        public List<int> Numberofemployee { get; set; }

    }
}
