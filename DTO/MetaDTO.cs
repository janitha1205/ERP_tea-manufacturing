using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class MetaDTO_FE
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name {  get; set; }
        public string About {  get; set; }
        [Required(ErrorMessage ="Please fill the content area")]
        public string MetaContent { get; set; }
    }


    public class MetaDTO_FM
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]
        public string MetaContent { get; set; }
    }


    public class MetaDTO_HRM
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]
        public string MetaContent { get; set; }
    }



    public class MetaDTO_HRE
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]
        public string MetaContent { get; set; }
    }



    public class MetaDTO_MO
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]
        public string MetaContent { get; set; }
    }
    public class MetaDTO_PE
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]
        public string MetaContent { get; set; }
    }



    public class MetaDTO_PM
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]
        public string MetaContent { get; set; }
    }


    public class MetaDTO_SE
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]
        public string MetaContent { get; set; }
    }
    public class MetaDTO_ST
    {
        public int ID { get; set; }
        public int MetaID { get; set; }
        public string Name { get; set; }
        public string About { get; set; }
        [Required(ErrorMessage = "Please fill the content area")]
        public string MetaContent { get; set; }
    }
}
