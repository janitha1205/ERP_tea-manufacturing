using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BOMDTO
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]


        public string Product_name { get; set; }
		public int Numberofprocess { get; set; }
                        //Withering Rolling Fermantation Drying Grading Colour-Soarting Furnace
                        
       

		
     
        
    }
}
