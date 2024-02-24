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
        public string p_name;
        public int count;
        public bool AddMeta(BOMDTO model,int t)
        {
           
                BOM bOM = new BOM
                {
                    UserID = UserStatic.ID,
                    Product_name = model.Product_name,
                    numberofprocess = model.Numberofprocess
                };
            p_name = model.Product_name;

                count=model.Numberofprocess;
            dao.Connectbom(bOM);


                return true;
            
           
        }
    }
}
