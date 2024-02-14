using System;
using System.Collections.Generic;
using System.Deployment.Internal;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web;
using System.Xml.Linq;

namespace ERP_1.Models
{
    public class Admin : Employee
    {
        public int ID { set; get; }


        public string Title { set; get; }
        public int Level { set; get; }
        public string password { set; get; }
        public int OrderStaff_id { set; get; }
        public string orderfromboss { set; get; }
        public string feedbacktoboss  { set; get; }

        public Dictionary<int, string> list_of_employee_id { get; set; }
        public Admin():base()
        {

            this.Level = 3;
            this.password = "abc123";
            this.Title = "Admin";
        }
        public Admin(int Id, int boss_id):base()
        {
            
            this.ID = Id;
            
            this.Level = 3;
            this.password="abc123";
            this.Title = "Admin";
            this.OrderStaff_id = boss_id;
        }
        public Admin(int Id, int boss_id,string name,string surename) : base(name,surename)
        {

            this.ID = Id;
            this.Name = name;
            this.SureName = surename;
            this.Level = 3;
            this.password = "abc123";
            this.Title = "Admin";
            this.OrderStaff_id = boss_id;
        }


    }
}
