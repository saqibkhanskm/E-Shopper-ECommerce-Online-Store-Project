using Data_Access_Layer_DL_.Models.UserModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer_DL_.Models.ModelRoles
{
    public class Roles
    {
        [Key]

        public Guid RoleId { get; set; }
        public string RoleName { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ICollection<User>? Users { get; set; }

    }
}
