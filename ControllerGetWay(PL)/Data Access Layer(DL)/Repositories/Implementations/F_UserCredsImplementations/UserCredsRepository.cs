using Data_Access_Layer_DL_.ApplicationDbContext;
using Data_Access_Layer_DL_.Models.UserModels;
using Data_Access_Layer_DL_.Repositories.Interfaces.F_UserCredsInterfaces;
using Shared.Enums.Operationstatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer_DL_.Repositories.Implementations.F_UserCredsImplementations
{
    public class UserCredsRepository : IUserCredsRepository
    {
        private readonly AppDbContext _appDbContext;
        public UserCredsRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<OperationStatusEnum> InsertUserCreds(UserCreds userCreds)
        {
            await _appDbContext.userCreds.AddAsync(userCreds);
            return OperationStatusEnum.Success;
        }
    }
}
