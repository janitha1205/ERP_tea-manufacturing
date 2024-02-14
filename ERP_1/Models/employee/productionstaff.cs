using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_1.Models
{
    public class productionstaff : Employee
    {
        public int ID { get; set; }

        public string Title { get; set; }
        public string password { get; set; }
        public int Level { get; set; }
        //administration
        public int OrderStaff_id { get; set; }
       
        public string orderfromboss { get; set; }
        
        public string feedbacktoboss { set; get; }
        //labours
        public Dictionary<int, string> order { get; set; }
        //labour
        public Dictionary<int, string> feedback { set; get; }

        productionstaff(int ID, int boss_id, string Name, string SureName):base(Name,SureName)
        {
            this.Name = Name;
            
            this.ID = ID;
            this.SureName = SureName;
            this.Level = 2;
            this.password = "abc123";
            this.Title = "production staff";
            this.OrderStaff_id = boss_id;
        }

    }
}

