using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MechineBLL
    {
        MechineDAO machdao = new MechineDAO();
        public bool AddMechine(mechineDTO meta)
        {
            Mechine status = new Mechine(); 
            status.MechID = meta.MechID;
            status.LabourID= meta.LabourID;
            status.Type = meta.Type;
            status.active_range= meta.active_range;
            status.Description = meta.Description;
            status.IsDown = meta.IsDown;
        //   machdao.AddMechine(status);
            


            return machdao.AddMechine(status); ;
            
        }
    }
}
