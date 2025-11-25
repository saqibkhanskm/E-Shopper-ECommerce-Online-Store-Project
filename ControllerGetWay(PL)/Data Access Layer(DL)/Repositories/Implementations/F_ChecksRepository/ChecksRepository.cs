using Data_Access_Layer_DL_.ApplicationDbContext;
using Data_Access_Layer_DL_.Repositories.Interfaces.F_ChecksInterfaces;
using Microsoft.EntityFrameworkCore;
using Shared.Enums.Operationstatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer_DL_.Repositories.Implementations.F_ChecksRepository
{
    public class ChecksRepository : IChecksRepository
    {
        private readonly AppDbContext _appDbContext;

        public ChecksRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public async Task<OperationStatusEnum> CheckUserEmail(string Email)
        {
          var Data= await _appDbContext.users.FirstOrDefaultAsync(u => u.Email == Email);
            if(Data != null)
            {
                return OperationStatusEnum.Existed;
            }
            return OperationStatusEnum.NotFound;
        }
    }
}
