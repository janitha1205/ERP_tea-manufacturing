using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_1.Models
{
    public class administration : Employee
    {
        public int ID { set; get; }



        public string Title { set; get; }
        public int Level { set; get; }
        public string password { set; get; }
        //management
        public int OrderStaff_id { set; get; }
        public string orderfromboss { set; get; }
        public string feedbacktoboss { set; get; }
        //production
        public Dictionary<int, string> order { get; set; }
        //production
        public Dictionary<int, string> feedback { set; get; }
        administration(int ID,int boss_id, string Name, string SureName):base(Name,SureName)
        {
            this.Name = Name;

            this.ID = ID;
            this.SureName = SureName;
            this.Level = 3;
            this.password = "abc123";
            this.Title = "administration staff";
            this.OrderStaff_id = boss_id;
        }

        public Dictionary<int,string> staffreport_as { get; set; }


        
    }
}