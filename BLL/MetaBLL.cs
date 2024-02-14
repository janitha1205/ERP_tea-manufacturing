using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BLL
{
    
    public class MetaBLL
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO model)
        {
            MetaInfo meta = new MetaInfo();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddDate = DateTime.Now;
            meta.LastUpdateUser = dao.userid().MetaID;
            meta.LastUpdateDate = dao.userid().AddDate;

            int id = 5;
           
            if( model.About== "material")
            {

                id = 1;
            }else if( model.About== "mechine")
            {
                id = 2;
            }
            else if (model.About == "employ")
            {
                id = 3;
            }
            else if (model.About == "rawmaterial")
            {
                id = 3;
            }
            else if (model.About == "Product")
            {
                id = 4;
            }



            dao.AddMeta(meta);
            LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added", id);
            return true;
        }

        public List<MetaDTO> GetMetaData()
        {
            List<MetaDTO> dtolist = new List<MetaDTO>();
            dtolist = dao.GetMetaData();
            return dtolist;
        }

        public MetaDTO GetMetaWithID(int id)
        {
            MetaDTO metadto= new MetaDTO();
            metadto = dao.GetMetaWithID(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO model)
        {
            dao.UpdateMeta(model);
            int id = 5;

            if (model.About == "material")
            {

                id = 1;
            }
            else if (model.About == "mechine")
            {
                id = 2;
            }
            else if (model.About == "employ")
            {
                id = 3;
            }
            else if (model.About == "rawmaterial")
            {
                id = 3;
            }
            else if (model.About == "Product")
            {
                id = 4;
            }
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table", id);
            return true;
        }
    }
}
