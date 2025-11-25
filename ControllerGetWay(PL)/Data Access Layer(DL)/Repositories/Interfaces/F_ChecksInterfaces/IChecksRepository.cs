using Shared.Enums.Operationstatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer_DL_.Repositories.Interfaces.F_ChecksInterfaces
{
    public interface IChecksRepository
    {
        Task<OperationStatusEnum> CheckUserEmail(string Email);
    }
}
