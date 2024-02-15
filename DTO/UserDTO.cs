using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.Data;

using System.Web;


namespace DTO
{
    public class UserDTO {
       // [Required(ErrorMessage = "fill the vaid user ID")]
        public int ID { get; set; }
      //  [Required(ErrorMessage = "fill the user username ")]

        public string UserName {  get; set; }
   //    [Required(ErrorMessage = "fill the user first name ")]

        public string Name { get; set; }
    //    [Required(ErrorMessage = "fill the user surename ")]

        public string SureName { get; set; }
        [Required(ErrorMessage ="fill the correct pasword")]
      
        public string Password { get; set; }
        public int info_ID { get; set; }
        public string boss_res { get; set; }
        public string staff_res { get; set; }
        public int session_ID { get; set; }
        [Display(Name = "User Image")]
        public HttpPostedFileBase UserImage { get; set; }
    //    [Required(ErrorMessage = "fill the user email address ")]

        public string email {  get; set; }
        public string imagepath {  get; set; }
    }
}

