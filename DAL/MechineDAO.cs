using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MechineDAO:PostContext
    {
        public bool AddMechine(Mechine meta)
        {
            try
            {
                db.Mechines.AddOrUpdate(meta);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
