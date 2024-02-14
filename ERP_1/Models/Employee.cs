using ERP_1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace ERP_1.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="Please fill the name area")]
        public string Name { get; set; }
        public DateTime SessionID;
        [Required(ErrorMessage = "Please fill the surename area")]
        public string SureName { get; set; }
         public Employee()
        {
            this.SessionID = DateTime.Now;
        }

        public Employee(string name,string surename)
        {
            this.SureName = surename;
            this.Name = name;
            this.SessionID = DateTime.Now;
        }
    }
}