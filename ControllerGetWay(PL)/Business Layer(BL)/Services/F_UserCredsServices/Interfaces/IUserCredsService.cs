using Business_Layer_BL_.DTOS.UserCredsDTO.F_InsertUserCredsDTO;
using Shared.Enums.Operationstatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_BL_.Services.F_UserCredsServices.Interfaces
{
    public interface IUserCredsService
    {
        Task<OperationStatusEnum> InsertUserCreds(InsertUserCredsDTO insertUserCredsDTO);
    }
}
