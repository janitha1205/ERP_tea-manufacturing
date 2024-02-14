using ERP_1.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Web;

namespace ERP_1.Models
{
    public class WorkInProcess
    {
        [Required(ErrorMessage = "Please fill the issue_ID area")]

        public int IssueID {  get; set; }
        [Required(ErrorMessage = "Please fill the name area")]

        public string Name { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "Please fill the ammount area")]

        public int Ammount { get; set; }
        [Required(ErrorMessage = "Please fill the last processed mechine name area")]

        public string Last_MechName { get; set; }
        [Required(ErrorMessage = "Please fill the upcoming processed mechine name area")]

        public string Next_MechName {  set; get; }
        [Required(ErrorMessage = "Please fill issued the staff id area")]

        public int Issued_Employee_id {  get; set; }
    }
}
