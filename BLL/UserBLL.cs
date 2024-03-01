using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class UserBLL

    {
        UserDAO userdao= new UserDAO();

        public void AddUser(UserDTO dto)
        {
            User_list newusr = new User_list();  
            newusr.Name = dto.Name; 
            newusr.SureName = dto.SureName; 
            newusr.Password = dto.Password;
            newusr.infor_ID = 16;
            newusr.imagepath = dto.imagepath;
            Random num = new Random();
            newusr.session_ID = num.Next();
            newusr.email = dto.email;
           
            newusr.username = dto.UserName;
            newusr.AddedDate=DateTime.Now;
            int id = userdao.AddUser(newusr);
            LogBLL.AddLog(General.Messegess.AddSuccess, "user is sucessfully added for further completion");

        }

        public List<UserDTO> GetUsers()
        {
            return userdao.GetUsers();
        }

        public UserDTO GetUserWithID(int id)
        {
            return userdao.GetUserWithID(id);
        }

        public UserDTO GetUserWithUsernameAndPassword(UserDTO model) {

            UserDTO dto = new UserDTO();
            dto=userdao.GetUserWithUsernameAndPassword(model);

            return dto;
        
        
        }

        public string UpdateUser(UserDTO dto)
        {
            string oldimgpath = userdao.UpdateUser(dto);

            LogBLL.AddLog(General.Messegess.UpdateSuccess, "changed the image path sucessfully ");

            return oldimgpath;
        }
    }
}
