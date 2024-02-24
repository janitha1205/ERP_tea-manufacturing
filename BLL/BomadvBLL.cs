using DAL;
using DTO;

namespace BLL
{
    public class BomadvBLL : BomBLL
    {
        BomadvDAO dao = new BomadvDAO();
        public bool AddMeta(BomAdv model)
        {
            string result1 = "";
            for (int i = 0; i < model.Numberofemployee.Count; i++)
            {
                if(i < model.Numberofemployee.Count - 1) {

                    result1 = result1 + model.Numberofemployee[i] + ",";

                }
                else {

                    result1 = result1 + model.Numberofemployee[i] ;

                }
                
            }
           
            string result2 = "";
            for (int i = 0; i < model.Mechine_id.Count; i++)
            {
                if (i < model.Mechine_id.Count - 1)
                {
                    result2 = result2 + model.Mechine_id[i] + ",";
                }
                else
                {
                    result2 = result2 + model.Mechine_id[i];
                }
                
            }
            string result3 = "";
            for (int i = 0; i < model.Mechine_name.Count; i++)
            {
                if (i < model.Mechine_name.Count - 1)
                {
                    result3 = result3 + model.Mechine_name[i] + ",";
                }
                else
                {
                    result3 = result3 + model.Mechine_name[i];
                }
            }

            BOM bOM2 = new BOM
            {
                UserID = UserStatic.ID,
                Product_name = UserStatic.pname,


                numberofprocess = UserStatic.numstations,

                ID = UserStatic.Lastid,
                listoflabourers = result1,
                listofmachineid = result2,
                listofprocessname = result3



            };
            dao.connectlog(bOM2);


            return true;








        }

    }
}
