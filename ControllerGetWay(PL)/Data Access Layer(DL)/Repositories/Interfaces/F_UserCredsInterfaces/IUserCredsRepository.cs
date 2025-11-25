using Data_Access_Layer_DL_.Models.UserModels;
using Shared.Enums.Operationstatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer_DL_.Repositories.Interfaces.F_UserCredsInterfaces
{
    public interface IUserCredsRepository
    {
        Task<OperationStatusEnum> InsertUserCreds(UserCreds userCreds);
    }
}
