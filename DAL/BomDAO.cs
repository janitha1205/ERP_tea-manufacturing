using DAL;
using System;

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
                return model.ID;

            }
            catch (Exception ex)
            {
                throw ex;

            }
        }





    }
}
    
