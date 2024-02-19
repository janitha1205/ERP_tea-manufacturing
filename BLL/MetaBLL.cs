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
    public class MetaBLL_FE
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_FE model)
        {
            Table_1 meta = new Table_1();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About = model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_FE(meta);
            // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_FE> GetMetaData_FE()
        {
            List<MetaDTO_FE> dtolist = new List<MetaDTO_FE>();
            dtolist = dao.GetMetaData_FE();
            return dtolist;
        }

        public MetaDTO_FE GetMetaWithID(int id)
        {
            MetaDTO_FE metadto = new MetaDTO_FE();
            metadto = dao.GetMetaWithID_FE(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_FE model)
        {
            dao.UpdateMeta_FE(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table FE");
            return true;
        }
    }
    public class MetaBLL_FM
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_FM model)
        {
            Table_2 meta = new Table_2();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About = model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_FM(meta);
           // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_FM> GetMetaData_FM()
        {
            List<MetaDTO_FM> dtolist = new List<MetaDTO_FM>();
            dtolist = dao.GetMetaData_FM();
            return dtolist;
        }


        public MetaDTO_FM GetMetaWithID(int id)
        {
            MetaDTO_FM metadto = new MetaDTO_FM();
            metadto = dao.GetMetaWithID_FM(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_FM model)
        {
            dao.UpdateMeta_FM(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table of FM");
            return true;
        }
    }




    public class MetaBLL_HRE
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_HRE model)
        {
            Table_3 meta = new Table_3();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About = model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_HRE(meta);
            // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_HRE> GetMetaData_HRE()
        {
            List<MetaDTO_HRE> dtolist = new List<MetaDTO_HRE>();
            dtolist = dao.GetMetaData_HRE();
            return dtolist;
        }

        public MetaDTO_HRE GetMetaWithID(int id)
        {
            MetaDTO_HRE metadto = new MetaDTO_HRE();
            metadto = dao.GetMetaWithID_HRE(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_HRE model)
        {
            dao.UpdateMeta_HRE(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table of HRE");
            return true;
        }
    }
    public class MetaBLL_HRM
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_HRM model)
        {
            Table_4 meta = new Table_4();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About = model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_HRM(meta);
            // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_HRM> GetMetaData_HRM()
        {
            List<MetaDTO_HRM> dtolist = new List<MetaDTO_HRM>();
            dtolist = dao.GetMetaData_HRM();
            return dtolist;
        }

        public MetaDTO_HRM GetMetaWithID(int id)
        {
            MetaDTO_HRM metadto = new MetaDTO_HRM();
            metadto = dao.GetMetaWithID_HRM(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_HRM model)
        {
            dao.UpdateMeta_HRM(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table of HRM");
            return true;
        }


    }


    public class MetaBLL_MO
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_MO model)
        {
            Table_5 meta = new Table_5();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About = model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_MO(meta);
            // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_MO> GetMetaData_MO()
        {
            List<MetaDTO_MO> dtolist = new List<MetaDTO_MO>();
            dtolist = dao.GetMetaData_MO();
            return dtolist;
        }


        public MetaDTO_MO GetMetaWithID(int id)
        {
            MetaDTO_MO metadto = new MetaDTO_MO();
            metadto = dao.GetMetaWithID_MO(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_MO model)
        {
            dao.UpdateMeta_MO(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table of MO");
            return true;
        }


    }

    public class MetaBLL_PE
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_PE model)
        {
            Table_6 meta = new Table_6();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About=model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_PE(meta);
            // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_PE> GetMetaData_PE()
        {
            List<MetaDTO_PE> dtolist = new List<MetaDTO_PE>();
            dtolist = dao.GetMetaData_PE();
            return dtolist;
        }



        public MetaDTO_PE GetMetaWithID(int id)
        {
            MetaDTO_PE metadto = new MetaDTO_PE();
            metadto = dao.GetMetaWithID_PE(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_PE model)
        {
            dao.UpdateMeta_PE(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table of PE");
            return true;
        }


    }

    public class MetaBLL_PM
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_PM model)
        {
            Table_7 meta = new Table_7();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About = model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_PM(meta);
            // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_PM> GetMetaData_PM()
        {
            List<MetaDTO_PM> dtolist = new List<MetaDTO_PM>();
            dtolist = dao.GetMetaData_PM();
            return dtolist;
        }

        public MetaDTO_PM GetMetaWithID(int id)
        {
            MetaDTO_PM metadto = new MetaDTO_PM();
            metadto = dao.GetMetaWithID_PM(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_PM model)
        {
            dao.UpdateMeta_PM(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table of PM");
            return true;
        }


    }

    public class MetaBLL_SE
    {
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_SE model)
        {
            Table_8 meta = new Table_8();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About = model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_SE(meta);
            // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_SE> GetMetaData_SE()
        {
            List<MetaDTO_SE> dtolist = new List<MetaDTO_SE>();
            dtolist = dao.GetMetaData_SE();
            return dtolist;
        }


        public MetaDTO_SE GetMetaWithID(int id)
        {
            MetaDTO_SE metadto = new MetaDTO_SE();
            metadto = dao.GetMetaWithID_SE(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_SE model)
        {
            dao.UpdateMeta_SE(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table of SE");
            return true;
        }


    }
    public class MetaBLL_ST { 
        MetaDAO dao = new MetaDAO();
        public bool AddMeta(MetaDTO_ST model)
        {
            Table_9 meta = new Table_9();
            meta.MetaID = UserStatic.ID;
            meta.MetaContent = model.MetaContent;
            meta.AddedDate = DateTime.Now;
            meta.About = model.About;
            meta.Name = model.Name;
            meta.isDeleted = false;
            if (dao.userid() != null)
            {
                meta.LastUpdatedUserID = dao.userid().MetaID;
                meta.LastUpdatedDate = dao.userid().AddedDate;
            }



            dao.AddMeta_ST(meta);
            // LogBLL.AddLog(General.Messegess.AddSuccess, "new comment has been added");
            return true;
        }

        public List<MetaDTO_ST> GetMetaData_ST()
        {
            List<MetaDTO_ST> dtolist = new List<MetaDTO_ST>();
            dtolist = dao.GetMetaData_ST();
            return dtolist;
        }

        public MetaDTO_ST GetMetaWithID(int id)
        {
            MetaDTO_ST metadto = new MetaDTO_ST();
            metadto = dao.GetMetaWithID_ST(id);
            return metadto;
        }

        public bool UpdateMeta(MetaDTO_ST model)
        {
            dao.UpdateMeta_ST(model);
            LogDAO.AddLog(General.Messegess.UpdateSuccess, "sucessfully updata mata table of ST");
            return true;
        }


    }
}


























