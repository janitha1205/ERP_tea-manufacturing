using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_1.Models
{
    public class Labour: Employee
    {
        public int ID { set; get; }

        public string Title { set; get; }
        public int Level { set; get; }
        public string password { set; get; }
        public float hours {  get; set; }
        //production
        public int OrderStaff_id { set; get; }
        
        public string orderfromboss { set; get; }
        
        public string feedbacktoboss { set; get; }



        Labour(int ID,int boss_id, string Name, string SureName):base(Name,SureName)
        {
            this.Name = Name;

            this.ID = ID;
            this.SureName = SureName;
            this.Level = 1;
            this.password = "abc123";
            this.Title = "Labour";
            this.OrderStaff_id = boss_id;
        }

    }
}