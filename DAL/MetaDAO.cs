using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MetaDAO : PostContext
    {
        public int AddMeta(MetaInfo meta)
        {
            try
            {
                db.MetaInfoes.Add(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public List<MetaDTO> GetMetaData()
        {
            List<MetaDTO> list= new List<MetaDTO>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x=>x.isDeleted!=true).OrderBy(x=>x.AddDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO dto= new MetaDTO();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;
                if (log != null)
                {

                    dto.ID = i;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name=log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;
                    

                }
                
                



            }
            
            return list;

        
        }

        public MetaDTO GetMetaWithID(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.MetaID == id);
            MetaDTO dto = new MetaDTO();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;  
            dto.MetaContent = meta.MetaContent;
            int infoId = db.User_list.FirstOrDefault(y => y.ID == meta.MetaID).infor_ID;
            string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;
            dto.About = dep;
            return dto;
        }

        public void UpdateMeta(MetaDTO model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.MetaID == model.MetaID);
                meta.MetaContent = model.MetaContent;
                meta.AddDate = meta.AddDate;
                meta.LastUpdateDate= DateTime.Now;
                meta.isDeleted = false;
                User_list user=new User_list();
                
                meta.LastUpdateUser = UserStatic.ID;
                user = db.User_list.FirstOrDefault(y => y.ID == meta.MetaID);
                user.Name = model.Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == meta.MetaID).infor_ID;
                staff stf= new staff();
                stf.Department = model.About;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public MetaInfo userid()
        {
           
            MetaInfo val2 = db.MetaInfoes.ToList().Last();
            return val2;
            
           }

    }
}

