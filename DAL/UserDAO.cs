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
    }
}
