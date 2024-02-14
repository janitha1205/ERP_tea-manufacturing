﻿using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SocialLogDAO : PostContext
    {
        public int AddSocialLog(SocialLog social)
        {
           try {                 
                db.SocialLogs.Add(social);
                db.SaveChanges();
                return social.ID;
            
            }catch(Exception ex) {
                throw ex;
            }
        }

        public List<SocialLogDTO> GetSocialLog()
        {
            List<SocialLog> list = db.SocialLogs.Where(x => x.IsDeleted == null).ToList();
            List<SocialLogDTO> dtolist= new List<SocialLogDTO>();
            foreach (var item in list)
            {
                SocialLogDTO dTO = new SocialLogDTO();  
                dTO.ID = item.ID;
                dTO.Name = item.Name;
                dTO.ImagePath = item.ImagePath;
                dTO.Link= item.Link;
                dtolist.Add(dTO);
            }
            return dtolist;
        }

        public SocialLogDTO GetSocialLogByID(int iD)
        {
            SocialLog social = db.SocialLogs.FirstOrDefault(x => x.ID == iD);
            SocialLogDTO dto = new SocialLogDTO();  
            if (social != null)
            {
                dto.ID = social.ID;
                dto.MetaID = social.LastUpdateUserID;
                dto.Name = social.Name;
                dto.Link = social.Link;
                dto.ImagePath = social.ImagePath;   
            }
            return dto;
        }
    }
}
     