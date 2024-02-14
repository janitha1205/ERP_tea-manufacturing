using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LogBLL
    {
        public static void AddLog(int processtype,string tablename,int processid)
        {
            LogDAO.AddLog(processtype,tablename,processid);
        }
    }
}
