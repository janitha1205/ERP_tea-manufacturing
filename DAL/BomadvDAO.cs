using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BomadvDAO:PostContext
    {
       public int connectlog(BOM model)
        {
            try
            {
                db.BOMs.AddOrUpdate(model);
                db.SaveChanges();
                return model.ID;

            }catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
