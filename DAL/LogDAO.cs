
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI.WebControls;
using DTO;
namespace DAL
{
    public class LogDAO : PostContext
    {
  

        public static void AddLog(int processType, string Tablename, int processID)
        {
           

                Log_Tab log = new Log_Tab();
                log.UserID = UserStatic.ID;
                log.ProcessType = processType;
                log.ProcessID = processID;
                log.ProcessCatType = Tablename;
                log.ProcessDate = DateTime.Now;
                log.ProcessIPAddress = HttpContext.Current.Request.UserHostAddress;

                db.Log_Tab.Add(log);
                db.SaveChanges();
            
            










        }
    }
}

