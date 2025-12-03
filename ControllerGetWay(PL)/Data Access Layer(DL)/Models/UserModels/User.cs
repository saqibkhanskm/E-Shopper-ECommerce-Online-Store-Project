using Data_Access_Layer_DL_.Models.SellesModels;
using Shared.Enums;
using System.ComponentModel.DataAnnotations;

namespace Data_Access_Layer_DL_.Models.UserModels
{
    public class User
    {
        [Key]
        public Guid UserId { get; set; }
        public string UserName { get; set; }=string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        public int RoleId { get; set; } 
        public UserRolesEnum Role {  get; set; }
        public UserCreds? UserCreds { get; set; }
        public ICollection<Sells>? Sells { get; set; }

    }
    public class UserCreds
    {
        [Key]

        public Guid CredsId { get; set; }
        public Guid UserId { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public User? User { get; set; }

    }
}
