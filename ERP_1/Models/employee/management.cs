using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_1.Models
{
    public class management : Employee
    {
        public int ID { set; get; }
        public string Title { set; get; }
        public int Level { set; get; }
        //administration
        public Dictionary<int,string> order { get; set; }
        //administration
        public Dictionary<int, string> feedback {  set; get; }   




        public string password { set; get; }
        management() :base(){
            this.Level = 4;
            this.password = "abc123";
            this.Title = "GM";
        }
        management(int ID, string Name, string SureName):base(Name,SureName)
        {
            this.Name = Name;
            
            this.ID = ID;
            this.SureName = SureName;
            this.Level = 4;
            this.password = "abc123";
            this.Title = "GM";
        }


    }
}