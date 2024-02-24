using DAL;
using DTO;
using System;
using System.Configuration;

namespace BLL
{
    public class BomDAO : PostContext
    {
        public int Connectbom(BOM model)
        {
            try
            {


                db.BOMs.Add(model);

                db.SaveChanges();
                UserStatic.Lastid = model.ID;
                return model.ID;


            }
            catch (Exception ex)
            {
                throw ex;

            }
        }





    }
}
    
