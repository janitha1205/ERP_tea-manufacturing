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
            LogDAO.AddLog(General.Messegess.AddSuccess, "user is sucessfully added for further completion", id);

        }

        public List<UserDTO> GetUsers()
        {
            return userdao.GetUsers();
        }

        public UserDTO GetUserWithUsernameAndPassword(UserDTO model) {

            UserDTO dto = new UserDTO();
            dto=userdao.GetUserWithUsernameAndPassword(model);

            return dto;
        
        
        }

    }
}
