using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Entity.Migrations.Model;
using System.Diagnostics;
using System.Data.Entity.Core;
using System.Data.Entity.Migrations;
namespace DAL
{
    public class UserDAO : PostContext
    {
        public int AddUser(User_list newusr)
        {
            UserDTO dto = new UserDTO();
            try
            {
                db.User_list.Add(newusr);
                db.SaveChanges();
                return newusr.ID;

               
                


            }catch(Exception ex) {

                throw ex;
            }
           
        }

        public List<UserDTO> GetUsers()
        {
            List<User_list> users = db.User_list.Where(x => x.infor_ID == 16).OrderBy(x=>x.AddedDate).ToList() ;  
            List<UserDTO> userlist=new List<UserDTO>();
            foreach(var itm in users)
            {
                UserDTO dto = new UserDTO();
                dto.ID= itm.ID;
                dto.Name= itm.Name;
                dto.UserName = itm.username;
                dto.SureName = itm.SureName;
                dto.imagepath = itm.imagepath;
                userlist.Add(dto);

            }
            return userlist;
        }

        public UserDTO GetUserWithID(int id)
        {
            User_list user = db.User_list.First(x => x.ID == id);
            UserDTO dto=  new UserDTO();
            if (user != null)
            {
                dto.ID = user.ID;
                dto.email = user.email;
                dto.Name = user.Name;
                dto.SureName= user.SureName;
                dto.imagepath = user.imagepath;
                dto.info_ID = user.infor_ID;
                dto.UserName= user.username;
                dto.session_ID= user.session_ID;
                dto.Password = user.Password;

                
            }
            return dto;
        }

        public UserDTO GetUserWithUsernameAndPassword(UserDTO model) {
            UserDTO dto= new UserDTO();
          
            try
            {
            var  user = db.User_list.FirstOrDefault(x => x.ID == model.ID && x.Password == model.Password);
                if (user != null)
                {
                    dto.Password = user.Password;
                    dto.ID = user.ID;

                    dto.Name = user.Name;

                    dto.SureName = user.SureName;



                    dto.info_ID = user.infor_ID;

                    dto.session_ID = user.session_ID;
                   dto.email=user.email;
                    dto.imagepath= user.imagepath;
                   
                         

              



                }
            return dto;


            }
            catch (Exception ex)
            {

                return dto;




            }

        }

        public string UpdateUser(UserDTO dto)
        {
            try {
                User_list user = db.User_list.First(x => x.ID == dto.ID);
                string oldaimagepath= user.imagepath.ToString();
                user.Name = dto.Name;
                user.username = dto.UserName;
                user.SureName= dto.SureName;
                if (dto.imagepath != null)
                {
                    user.imagepath= dto.imagepath;  
                }
                user.email = dto.email;
                user.Password= dto.Password;
                user.AddedDate = DateTime.Now;
                user.session_ID = dto.session_ID;
                user.infor_ID = dto.info_ID;
               
                db.User_list.AddOrUpdate(user);
                return oldaimagepath;

            }
            catch(Exception ex) { throw ex; }
        }
    }
}
