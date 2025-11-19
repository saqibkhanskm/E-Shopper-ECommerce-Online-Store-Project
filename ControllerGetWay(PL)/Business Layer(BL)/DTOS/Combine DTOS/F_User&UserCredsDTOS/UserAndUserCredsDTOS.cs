using Business_Layer_BL_.DTOS.UserCredsDTO.F_InsertUserCredsDTO;
using Business_Layer_BL_.DTOS.UserDTOS.F_UserInsertDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_BL_.DTOS.Combine_DTOS.F_User_UserCredsDTOS
{
    public class UserAndUserCredsDTOS
    {
        public InsertUserCredsDTO? insertUserCredsDTO { get; set; }
        public InsertUserDTO ? InsertUserDTO { get; set; }
    }
}
