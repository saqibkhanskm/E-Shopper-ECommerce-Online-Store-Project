using Data_Access_Layer_DL_.Models.UserModels;
using Shared.Enums.Operationstatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer_DL_.Repositories.Interfaces.F_UserIntrfaces
{
    public interface IUserRepository
    {

        Task<OperationStatusEnum> InsertUser(User user);
        Task<OperationStatusEnum> UpdateUser(User user);
        Task<OperationStatusEnum> RetrieveUser(User user);
    }
}
