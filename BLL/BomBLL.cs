using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BomBLL
    {
        BomDAO dao = new BomDAO();
       
        public bool AddMeta(BOMDTO model)
        {


            BOM bOM = new BOM
            {
                UserID = UserStatic.ID,
                Product_name = model.Product_name,
                numberofprocess = model.Numberofprocess
                   
                };
            UserStatic.numstations = model.Numberofprocess;
            UserStatic.pname = model.Product_name;
            dao.Connectbom(bOM);


               
            return true;
            
           
        }
    }
}
