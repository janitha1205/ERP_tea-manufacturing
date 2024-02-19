using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
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
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public List<MetaDTO_FM> GetMetaData_FM()
        {
            List<MetaDTO_FM> list = new List<MetaDTO_FM>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_FM dto = new MetaDTO_FM();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;
                if (log != null)
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }

        public List<MetaDTO_FE> GetMetaData_FE()
        {
            List<MetaDTO_FE> list = new List<MetaDTO_FE>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_FE dto = new MetaDTO_FE();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;
                // "FM" 12, "HRM"14, "PM" 6,"ST" 3 4 
                //"mechine", "employ","wages","leaves"
                if (log != null &&(dep=="mechine"|| dep== "employ"|| dep=="wages"|| dep=="leaves")&&(infoId == 12 || infoId == 14 || infoId == 6 || infoId == 4 || infoId == 3))
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }




        public List<MetaDTO_HRE> GetMetaData_HRE()
        {
            List<MetaDTO_HRE> list = new List<MetaDTO_HRE>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_HRE dto = new MetaDTO_HRE();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;


                //"HRM" 14, "MO" 1 2, "PE 5","SE"  13,"ST" 3 4
                if (log != null && (dep== "employ"|| dep=="wages"||dep=="leaves")&&(infoId==1 || infoId==2 || infoId==3|| infoId==4 || infoId==13||  infoId==14))
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }

        public List<MetaDTO_HRM> GetMetaData_HRM()
        {
            List<MetaDTO_HRM> list = new List<MetaDTO_HRM>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_HRM dto = new MetaDTO_HRM();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;

                //log != null && (dep== "employ"|| dep=="wages"||dep=="leaves")&&(infoId==12 || infoId==8 || infoId==6|| infoId==7 || infoId==13||  infoId==14)
                // "employ","wages","leaves"
                //                                                                "FM" 12, "HRE" 8, "PM" 6,"FE" 7
                if (log != null && (dep == "employ" || dep == "wages" || dep == "leaves") &&(infoId == 12 || infoId == 8 || infoId == 6 || infoId == 7))
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }

        public List<MetaDTO_MO> GetMetaData_MO()
        {
            List<MetaDTO_MO> list = new List<MetaDTO_MO>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_MO dto = new MetaDTO_MO();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;

                //   "material", "mechine", "employ", "rawmaterial","Product","wages","leaves"
                //"ST" 3 4, "HRE" 8, "PE" 5,"SE" 13
                //&& (infoId == 3 || infoId == 4 || infoId == 8 || infoId == 5 || infoId == 13 || infoId == 14)
                if (log != null &&(dep=="material"|| dep== "mechine" || dep== "rawmaterial" || dep=="Product"|| dep=="leaves") && (infoId == 3 || infoId == 4 || infoId == 8 || infoId == 5 || infoId == 13))
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }

        public List<MetaDTO_PE> GetMetaData_PE()
        {
            List<MetaDTO_PE> list = new List<MetaDTO_PE>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_PE dto = new MetaDTO_PE();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;
                //"SE" 13, "MO" 1 2, "PM" 6,"HRE" 8,"ST" 3 4
                //"material", "mechine", "employ", "rawmaterial","Product","leaves"
                //&& (infoId == 1 || infoId == 2 || infoId == 6 || infoId == 8 || infoId == 13 || infoId == 4 || infoId== 3)
                if (log != null && (dep == "material" || dep == "mechine" || dep == "employ" || dep == "rawmaterial" || dep == "Product" || dep == "leaves") && (infoId == 1 || infoId == 2 || infoId == 6 || infoId == 8 || infoId == 13 || infoId == 4 || infoId == 3))
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }

        public List<MetaDTO_PM> GetMetaData_PM()
        {
            List<MetaDTO_PM> list = new List<MetaDTO_PM>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_PM dto = new MetaDTO_PM();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;

                // "FE" 7, "HRM" 14, "PE" 5,"SE" 13, "FM" 12

                //&& ( infoId == 7 || infoId == 14 || infoId == 5 || infoId == 13 || infoId== 3)

                if (log != null && (dep == "material" || dep == "mechine" || dep == "employ" || dep == "rawmaterial" || dep == "Product" || dep == "wages" || dep == "leaves") && (infoId == 7 || infoId == 14 || infoId == 5 || infoId == 13 || infoId == 3))
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }
        public List<MetaDTO_SE> GetMetaData_SE()
        {
            List<MetaDTO_SE> list = new List<MetaDTO_SE>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_SE dto = new MetaDTO_SE();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;
                //"material", "mechine", "employ", "rawmaterial","Product","wages","leaves"
                //"ST" 3 4, "HRE" 8, "PE" 5,"FE" 7

                //&& ( infoId == 7 || infoId == 8 || infoId == 5 || infoId == 3 || infoId== 4 || IndoId==13)
                if (log != null && (dep=="material" || dep== "rawmaterial" || dep=="Product" || dep== "leaves") && (infoId == 7 || infoId == 8 || infoId == 5 || infoId == 3 || infoId == 4))
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }

        public List<MetaDTO_ST> GetMetaData_ST()
        {
           List<MetaDTO_ST> list = new List<MetaDTO_ST>();
            List<MetaInfo> matalist = db.MetaInfoes.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            int i = 1;
            foreach (var item in matalist)
            {
                MetaDTO_ST dto = new MetaDTO_ST();
                int val = item.MetaID;
                string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;
                //"mechine", "employ","wages","leaves"
                //"FE" 7, "HRE" 8, "PE" 5,"MO" 1 2,"SE" 13
                //&& ( infoId == 7 || infoId == 8 || infoId == 5 || infoId == 1 || infoId== 2 || IndoId==13)
                if (log != null &&(dep=="mechine"|| dep== "employ"|| dep=="wages" || dep== "leaves") && (infoId == 7 || infoId == 8 || infoId == 5 || infoId == 1 || infoId == 2 || infoId == 13))
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = log;
                    dto.About = dep;
                    list.Add(dto);
                    i = i + 1;


                }





            }

            return list;


        }


        public MetaDTO_FE GetMetaWithID_FE(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_FE dto = new MetaDTO_FE();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_FE(MetaDTO_FE model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public MetaDTO_FM GetMetaWithID_FM(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_FM dto = new MetaDTO_FM();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_FM(MetaDTO_FM model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public MetaDTO_HRE GetMetaWithID_HRE(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_HRE dto = new MetaDTO_HRE();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_HRE(MetaDTO_HRE model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public MetaDTO_HRM GetMetaWithID_HRM(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_HRM dto = new MetaDTO_HRM();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_HRM(MetaDTO_HRM model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MetaDTO_MO GetMetaWithID_MO(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_MO dto = new MetaDTO_MO();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_HRM(MetaDTO_MO model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MetaDTO_PE GetMetaWithID_PE(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_PE dto = new MetaDTO_PE();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_PE(MetaDTO_PE model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MetaDTO_PM GetMetaWithID_PM(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_PM dto = new MetaDTO_PM();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_PM(MetaDTO_PM model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public MetaDTO_SE GetMetaWithID_SE(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_SE dto = new MetaDTO_SE();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_SE(MetaDTO_SE model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public MetaDTO_ST GetMetaWithID_ST(int id)
        {
            MetaInfo meta = db.MetaInfoes.First(x => x.ID == id);
            MetaDTO_ST dto = new MetaDTO_ST();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;

            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_ST(MetaDTO_ST model)
        {
            try
            {
                MetaInfo meta = db.MetaInfoes.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;


                meta.LastUpdatedUserID = UserStatic.ID;

                db.MetaInfoes.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MetaInfo userid()
        {
            try
            {

                MetaInfo val2 = db.MetaInfoes.ToList().Last();


                return val2;


            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void UpdateMeta_MO(MetaDTO_MO model)
        {
            throw new NotImplementedException();
        }
    }
}

