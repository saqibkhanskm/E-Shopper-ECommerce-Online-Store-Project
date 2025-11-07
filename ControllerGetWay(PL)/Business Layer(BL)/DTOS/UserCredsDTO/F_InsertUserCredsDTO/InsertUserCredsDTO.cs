using Data_Access_Layer_DL_.Models.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_BL_.DTOS.UserCredsDTO.F_InsertUserCredsDTO
{
    public class InsertUserCredsDTO
    {
        public Guid CredsId { get; set; }
        public Guid UserId { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}
