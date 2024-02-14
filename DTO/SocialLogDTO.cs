using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace DTO
{
    public class SocialLogDTO
    {
        public int ID { get; set; }
        public int MetaID {  get; set; }
        [Required(ErrorMessage = "Please fill the name property")]
        public string Name { get; set; }
        public string ImagePath { get; set; }
        [Required(ErrorMessage ="fill the link to profile")]
        public string Link {  get; set; }
        [Display(Name="image")]
        public HttpPostedFileBase SocialImage { get; set; } 

    }
}
