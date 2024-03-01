using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BomadvBLL:BomBLL
    {
        BomadvDAO dao = new BomadvDAO();
        public bool connectlog(BomAdv model)
        {
            string result1 = "";
            for (int i = 0; i < model.Numberofemployee.Count; i++)
            {
                result1 = result1 + model.Numberofemployee[i] + ",";
            }
            string result2 = "";
            for (int i = 0; i < model.Mechine_id.Count; i++)
            {
                result2 = result2 + model.Mechine_id[i] + ",";
            }
            string result3 = "";
            for (int i = 0; i < model.Mechine_id.Count; i++)
            {
                result3 = result3 + model.Mechine_id[i] + ",";
            }
            BOM bOM2 = new BOM
            {
                UserID = UserStatic.ID,
                Product_name=p_name,
                numberofprocess=count,
          
            
                listoflabourers =result1,
                listofmachineid=result2,
                listofprocessname=result3


               
            };
            dao.connectlog(bOM2);


            return true;







            return true;
        }

}
