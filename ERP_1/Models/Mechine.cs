using ERP_1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;
namespace ERP_1.Models
{
    public class Mechine
    {
        [Required(ErrorMessage = "Please fill mechine name")]

        public string MechName {  get; set; }
        [Required(ErrorMessage = "Please fill some discription")]

        public string Description { get; set; }
        [Required(ErrorMessage = "Please fill catagory belogs to the mechine")]

        public string Type { get; set; }
        [Required(ErrorMessage = "Please fill your staff id")]

        public int LabourID { get; set; }
    

        public bool IsDown {  get; set; }
        [Required(ErrorMessage = "Please fill the current presistence working hours")]

        public float HoursWorked {  get; set; }
        public Mechine()
        {
            this.IsDown = false;
            this.HoursWorked = 0;
        }
    }
}