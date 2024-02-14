using ERP_1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace ERP_1.Models
{
    public class Material
    {
        [Required(ErrorMessage = "Please fill the name area")]

        public string Name { get; set; }
        [Required(ErrorMessage = "Please fill the required ammount")]

        public int Required_ammount { get; set; }
        [Required(ErrorMessage = "Please fill the available ammount")]

        public int Available_ammount { get; set; }
        public string Note { get; set; }
        [Required(ErrorMessage = "Please fill your staff id")]

        public int Staff_id {  get; set; }
        [Required(ErrorMessage = "Please fill the issue id")]

        public int IssueID { get; set; }
        public Material()
        {
            this.Required_ammount = 0;
            this.Available_ammount = 0;
        }

    }
}