using Data_Access_Layer_DL_.Models.SellesModels;
using Data_Access_Layer_DL_.Models.UserModels;
using Shared.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_BL_.DTOS.UserDTOS.F_UserInsertDTO
{
    public class InsertUserDTO
    {
        public Guid UserId { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int RoleId { get; set; }
        public UserRolesEnum Role { get; set; }
    }
}
