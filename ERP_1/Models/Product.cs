using ERP_1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace ERP_1.Models
{
    public class Product
    {
        [Required(ErrorMessage = "Please fill the Number area")]

        public int Product_ID {  get; set; }
        [Required(ErrorMessage = "Please fill the name area")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please fill the target ammount in the area")]

        public int Target{ get; set; }
        [Required(ErrorMessage = "Please fill the actual ammount in the area")]

        public int Actual {  get; set; }
        [Required(ErrorMessage = "Please fill the catagory belogs to product")]

        public string type { get; set; }
        public string Note { get; set; }

        public Product()
        {
            this.Target = 0;
            this.Actual=0;
        }
    }
}