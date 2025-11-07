using Data_Access_Layer_DL_.Models.UserModels;
using Data_Access_Layer_DL_.Repositories.Interfaces.F_UserIntrfaces;
using Shared.Enums.Operationstatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer_DL_.Repositories.Implementations.F_UserImplementations
{
    public class UserRepository : IUserRepository
    {
        public Task<OperationStatusEnum> InsertUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<OperationStatusEnum> RetrieveUser(User user)
        {
            throw new NotImplementedException();
        }

        public Task<OperationStatusEnum> UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
