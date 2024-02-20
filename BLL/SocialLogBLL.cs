using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SocialLogBLL
    {
        SocialLogDAO dao=new SocialLogDAO();
        public bool AddSocialLog(SocialLogDTO dto)
        {
            SocialLog social=new SocialLog();
            social.Name= dto.Name;
            social.Link= dto.Link;
            social.ImagePath= dto.ImagePath;
            social.AddDate = DateTime.Now;
            social.LastUpdateDate = DateTime.Now;
            social.LastUpdateUserID = UserStatic.ID;

            int ID=dao.AddSocialLog(social);
            LogDAO.AddLog(General.Messegess.AddSuccess, "Social Log Has been Sucessfully added", ID);
               
           
            return true;
        }

        public List<SocialLogDTO> GetSocialLog()
        {
            List<SocialLogDTO> dtolist= new List<SocialLogDTO>();
            dtolist = dao.GetSocialLog();
            return dtolist;
        }

        public SocialLogDTO GetSocialLogByID(int iD)
        {
            SocialLogDTO dto = dao.GetSocialLogByID(iD);
            return dto;
        }

        public string UpdateSocialLog(SocialLogDTO model)
        {
            string oldimg = dao.UpdateSocialLog(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "Change img path from" + oldimg,model.ID);
            return oldimg;
        }
    }
}

