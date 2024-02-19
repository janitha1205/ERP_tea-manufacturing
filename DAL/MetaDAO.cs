using DTO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MetaDAO : PostContext
    {
        public int AddMeta_FE(Table_1 meta)
        {
            try
            {
                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddMeta_FM(Table_2 meta)
        {
            try
            {
                db.Table_2.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddMeta_HRE(Table_3 meta)
        {
            try
            {
                db.Table_3.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddMeta_HRM(Table_4 meta)
        {
            try
            {
                db.Table_4.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddMeta_MO(Table_5 meta)
        {
            try
            {
                db.Table_5.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddMeta_PE(Table_6 meta)
        {
            try
            {
                db.Table_6.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddMeta_PM(Table_7 meta)
        {
            try
            {
                db.Table_7.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddMeta_SE(Table_8 meta)
        {
            try
            {
                db.Table_8.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int AddMeta_ST(Table_9 meta)
        {
            try
            {
                db.Table_9.AddOrUpdate(meta);
                db.SaveChanges();
                return meta.MetaID;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<MetaDTO> merge_data()
        {
            List<MetaDTO> list = new List<MetaDTO>();
            List<Table_1> matalist1 = db.Table_1.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            List<Table_2> matalist2 = db.Table_2.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            List<Table_3> matalist3 = db.Table_3.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            List<Table_4> matalist4 = db.Table_4.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            List<Table_5> matalist5 = db.Table_5.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            List<Table_6> matalist6 = db.Table_6.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            List<Table_7> matalist7 = db.Table_7.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            List<Table_8> matalist8 = db.Table_8.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            List<Table_9> matalist9 = db.Table_9.Where(x => x.isDeleted != true).OrderBy(x => x.AddedDate).ToList();
            foreach (var item in matalist1)
            {
                MetaDTO dto = new MetaDTO();



                if (item.MetaContent != null)
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = item.Name;
                    dto.About = item.About;
                    list.Add(dto);

                }
            }
            foreach (var item in matalist2)
            {
                MetaDTO dto = new MetaDTO();



                if (item.MetaContent != null)
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = item.Name;
                    dto.About = item.About;
                    list.Add(dto);

                }
            }
            foreach (var item in matalist3)
            {
                MetaDTO dto = new MetaDTO();



                if (item.MetaContent != null)
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = item.Name;
                    dto.About = item.About;
                    list.Add(dto);

                }
            }
            foreach (var item in matalist4)
            {
                MetaDTO dto = new MetaDTO();



                if (item.MetaContent != null)
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = item.Name;
                    dto.About = item.About;
                    list.Add(dto);

                }
            }
                foreach (var item in matalist5)
                {
                    MetaDTO dto = new MetaDTO();



                    if (item.MetaContent != null)
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);

                    }
                }
                foreach (var item in matalist6)
                {
                    MetaDTO dto = new MetaDTO();



                    if (item.MetaContent != null)
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);

                    }
                }
                foreach (var item in matalist7)
                {
                    MetaDTO dto = new MetaDTO();



                    if (item.MetaContent != null)
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);

                    }
                }
                foreach (var item in matalist8)
                {
                    MetaDTO dto = new MetaDTO();



                    if (item.MetaContent != null)
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);

                    }
                }
            foreach (var item in matalist9)
            {
                MetaDTO dto = new MetaDTO();



                if (item.MetaContent != null)
                {

                    dto.ID = item.ID;
                    dto.MetaID = item.MetaID;
                    dto.MetaContent = item.MetaContent;
                    dto.Name = item.Name;
                    dto.About = item.About;
                    list.Add(dto);

                }
            }
            return list;

        }
        public List<MetaDTO_FE> GetMetaData_FE()
        {
            try
            {
                List<MetaDTO_FE> list = new List<MetaDTO_FE>();
                List<MetaDTO> matalist = merge_data();

                foreach (var item in matalist)
                {
                    MetaDTO_FE dto = new MetaDTO_FE();

                    // item.Name=="FM"|| item.Name=="HRM"14|| item.Name=="PM"||item.Name=="ST" 3 4 
                    //"mechine", "employ","wages","leaves"
                    if (item.MetaContent != null && (item.About == "mechine" || item.About == "employ" || item.About == "wages" || item.About == "leaves") && (item.Name == "FM" || item.Name == "HRM" || item.Name == "PM" || item.Name == "ST"))
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);



                    }





                }

                return list;

            }
            catch (Exception ex)
            {
                return null;
            }
        }
        public List<MetaDTO_FM> GetMetaData_FM()
        {
            try
            {
                List<MetaDTO_FM> list = new List<MetaDTO_FM>();

                List<MetaDTO> matalist = merge_data();

                foreach (var item in matalist)
                {
                    MetaDTO_FM dto = new MetaDTO_FM();
                 
                   
                    
                    if (item.MetaContent != null)
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);
                       


                    }





                }

                return list;
            }catch(Exception ex)
            {
                return null;
            }

        }

       




        public List<MetaDTO_HRE> GetMetaData_HRE()
        {
            try
            {
                List<MetaDTO_HRE> list = new List<MetaDTO_HRE>();
                List<MetaDTO> matalist = merge_data();
                foreach (var item in matalist)
                {
                    MetaDTO_HRE dto = new MetaDTO_HRE();



                    //item.Name=="HRM"||item.Name== "MO" ||item.Name== "PE"|| item.Name=="SE"||item.Name=="ST"
                    if (item.MetaContent != null && (item.About == "employ" || item.About == "wages" || item.About == "leaves") && (item.Name == "HRM" || item.Name == "MO" || item.Name == "PE" || item.Name == "SE" || item.Name == "ST"))
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);
              


                    }





                }

                return list;
            }catch (Exception ex)
            {
                return null;
            }

        }

        public List<MetaDTO_HRM> GetMetaData_HRM()
        {
            try
            {
                List<MetaDTO_HRM> list = new List<MetaDTO_HRM>();
                List<MetaDTO> matalist = merge_data();
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
                    if (item.MetaContent != null && (item.About == "employ" || item.About == "wages" || item.About == "leaves") && (item.Name == "FM" || item.Name == "HRE" || item.Name == "PM" || item.Name == "FE"))
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);
                       


                    }





                }

                return list;
            }catch (Exception ex)
            {
                return null;
            }

        }

        public List<MetaDTO_MO> GetMetaData_MO()
        {
            try
            {
                List<MetaDTO_MO> list = new List<MetaDTO_MO>();
                List<MetaDTO> matalist = merge_data();
                foreach (var item in matalist)
                {
                    MetaDTO_MO dto = new MetaDTO_MO();
                    int val = item.MetaID;
                    string log = db.User_list.FirstOrDefault(y => y.ID == val).Name;
                    int infoId = db.User_list.FirstOrDefault(y => y.ID == val).infor_ID;
                    string dep = db.staffs.FirstOrDefault(y => y.ID == infoId).Department;

                    //   "material", "mechine", "employ", "rawmaterial","Product","wages","leaves"
                    //item.Name="ST"|| item.Name=="HRE" || item.Name== "PE"|| item.Name=="SE" 
                    //&& (infoId == 3 || infoId == 4 || infoId == 8 || infoId == 5 || infoId == 13 || infoId == 14)
                    if (item.MetaContent != null && (item.About == "material" || item.About == "mechine" || item.About == "rawmaterial" || item.About == "Product" || item.About == "leaves") && (item.Name == "ST" || item.Name == "HRE" || item.Name == "PE" || item.Name == "SE"))
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);



                    }





                }

                return list;

            }catch(Exception ex)
            {
                return null;
            }
        }

        public List<MetaDTO_PE> GetMetaData_PE()
        {
            try
            {
                List<MetaDTO_PE> list = new List<MetaDTO_PE>();
                List<MetaDTO> matalist = merge_data(); 
                foreach (var item in matalist)
                {
                    MetaDTO_PE dto = new MetaDTO_PE();
                   
                    //item.Name=="SE" || item.Name=="MO" || item.Name=="PM"||item.Name=="HRE"||item.Name=="ST"
                    //"material", "mechine", "employ", "rawmaterial","Product","leaves"
                    //&& (infoId == 1 || infoId == 2 || infoId == 6 || infoId == 8 || infoId == 13 || infoId == 4 || infoId== 3)
                    if (item.MetaContent != null && (item.About == "material" || item.About == "material" || item.About == "mechine" || item.About == "employ" || item.About == "rawmaterial" || item.About == "Product" || item.About == "leaves") && (item.Name == "SE" || item.Name == "MO" || item.Name == "PM" || item.Name == "HRE" || item.Name == "ST"))                {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);
                     


                    }





                }

                return list;

            }catch(Exception ex)
            {
                return null;
            }
        }

        public List<MetaDTO_PM> GetMetaData_PM()
        {
            try
            {
                List<MetaDTO_PM> list = new List<MetaDTO_PM>();
                List<MetaDTO> matalist = merge_data();
                foreach (var item in matalist)
                {
                    MetaDTO_PM dto = new MetaDTO_PM();
                

                    // item.Name=="FE"||item.Name== "HRM" ||item.Name== "PE" ||item.Name=="SE" ||item.Name== "FM" 

                    //&& ( infoId == 7 || infoId == 14 || infoId == 5 || infoId == 13 || infoId== 3)

                    if (item.MetaContent != null && (item.About == "material" || item.About == "mechine" || item.About == "employ" || item.About == "rawmaterial" || item.About == "Product" || item.About == "wages" || item.About == "leaves") && (item.Name == "FE" || item.Name == "HRM" || item.Name == "PE" || item.Name == "SE" || item.Name == "FM"))
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);
                        


                    }





                }

                return list;

            }catch (Exception ex)
            {
                return null;
            }
        }
        public List<MetaDTO_SE> GetMetaData_SE()
        {
            try
            {
                List<MetaDTO_SE> list = new List<MetaDTO_SE>();
                List<MetaDTO> matalist = merge_data();
                foreach (var item in matalist)
                {
                    MetaDTO_SE dto = new MetaDTO_SE();

                    //"material", "mechine", "employ", "rawmaterial","Product","wages","leaves"
                    //item.Name=="ST"||item.Name=="HRE"||item.Name=="PE"||item.Name=="FE"

                    //&& ( infoId == 7 || infoId == 8 || infoId == 5 || infoId == 3 || infoId== 4 || IndoId==13)
                    if (item.MetaContent != null && (item.About == "material" || item.About == "rawmaterial" || item.About == "Product" || item.About == "leaves") && (item.Name == "ST" || item.Name == "HRE" || item.Name == "PE" || item.Name == "FE"))
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);
                      


                    }





                }

                return list;
            }catch(Exception ex)
            {
                return null;
            }

        }

        public List<MetaDTO_ST> GetMetaData_ST()
        {
            try
            {
                List<MetaDTO_ST> list = new List<MetaDTO_ST>();
                List<MetaDTO> matalist = merge_data();
                foreach (var item in matalist)
                {
                    MetaDTO_ST dto = new MetaDTO_ST();

                    //"mechine", "employ","wages","leaves"
                    //item.Name=="FE"||item.Name=="HRE"||item.Name== "PE"||item.Name=="MO"||item.Name=="SE"
                    //&& ( infoId == 7 || infoId == 8 || infoId == 5 || infoId == 1 || infoId== 2 || IndoId==13)
                    if (item.MetaContent != null && (item.About == "mechine" || item.About == "employ" || item.About == "wages" || item.About == "leaves") && (item.Name == "FE" || item.Name == "HRE" || item.Name == "PE" || item.Name == "MO" || item.Name == "SE"))
                    {

                        dto.ID = item.ID;
                        dto.MetaID = item.MetaID;
                        dto.MetaContent = item.MetaContent;
                        dto.Name = item.Name;
                        dto.About = item.About;
                        list.Add(dto);
                      


                    }





                }

                return list;

            }catch (Exception ex)
            {
                return null;
            }
        }


        public MetaDTO_FE GetMetaWithID_FE(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_FE dto = new MetaDTO_FE();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About=meta.About;
            dto.Name=meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_FE(MetaDTO_FE model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;
                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;
                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public MetaDTO_FM GetMetaWithID_FM(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_FM dto = new MetaDTO_FM();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About = meta.About;
            dto.Name = meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_FM(MetaDTO_FM model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;
                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;

                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public MetaDTO_HRE GetMetaWithID_HRE(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_HRE dto = new MetaDTO_HRE();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About = meta.About;
            dto.Name = meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_HRE(MetaDTO_HRE model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;
                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;

                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
       
        public MetaDTO_HRM GetMetaWithID_HRM(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_HRM dto = new MetaDTO_HRM();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About = meta.About;
            dto.Name = meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_HRM(MetaDTO_HRM model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;
                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;

                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public MetaDTO_MO GetMetaWithID_MO(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_MO dto = new MetaDTO_MO();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About = meta.About;
            dto.Name = meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_HRM(MetaDTO_MO model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;
                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;

                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MetaDTO_PE GetMetaWithID_PE(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_PE dto = new MetaDTO_PE();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About = meta.About;
            dto.Name = meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_PE(MetaDTO_PE model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;

                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;
                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public MetaDTO_PM GetMetaWithID_PM(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_PM dto = new MetaDTO_PM();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About = meta.About;
            dto.Name = meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_PM(MetaDTO_PM model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;
                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;

                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public MetaDTO_SE GetMetaWithID_SE(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_SE dto = new MetaDTO_SE();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About = meta.About;
            dto.Name = meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_SE(MetaDTO_SE model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;
                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;

                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        public MetaDTO_ST GetMetaWithID_ST(int id)
        {
            Table_1 meta = db.Table_1.First(x => x.ID == id);
            MetaDTO_ST dto = new MetaDTO_ST();
            dto.ID = meta.ID;
            dto.MetaID = meta.MetaID;
            dto.About = meta.About;
            dto.Name = meta.Name;
            dto.MetaContent = meta.MetaContent;
            return dto;
        }

        public void UpdateMeta_ST(MetaDTO_ST model)
        {
            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;

                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;
                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public Table_1 userid()
        {
            try
            {

                Table_1 val2 = db.Table_1.ToList().Last();


                return val2;


            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public void UpdateMeta_MO(MetaDTO_MO model)
        {

            try
            {
                Table_1 meta = db.Table_1.First(x => x.ID == model.ID);
                meta.MetaContent = model.MetaContent;
                meta.AddedDate = meta.AddedDate;
                meta.LastUpdatedDate = DateTime.Now;
                meta.isDeleted = false;
                meta.MetaID = model.MetaID;
                meta.About = model.About;
                meta.Name = model.Name;
                meta.ID = model.ID;

                meta.LastUpdatedUserID = UserStatic.ID;

                db.Table_1.AddOrUpdate(meta);
                db.SaveChanges();






            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

