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
