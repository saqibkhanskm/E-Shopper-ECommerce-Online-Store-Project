using Business_Layer_BL_.DTOS.UserCredsDTO.F_UpdateUserCredsDTO;
using Business_Layer_BL_.DTOS.UserDTOS.F_UserInsertDTO;
using Business_Layer_BL_.DTOS.UserDTOS.F_UserRetriveDTO;
using Business_Layer_BL_.Services.F_UserServices.Interfaces;
using Shared.Enums.Operationstatus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer_BL_.Services.F_UserServices.Implementations
{
    public class UserServices : IUserServices
    {
        public Task<OperationStatusEnum> InsertUser(InsertUserDTO insertUserDTO)
        {
            throw new NotImplementedException();
        }

        public Task<OperationStatusEnum> RetrieveUser(UserRetriveDTO userRetriveDTO)
        {
            throw new NotImplementedException();
        }

        public Task<OperationStatusEnum> UpdateUser(UpdateUserCredsDTO updateUserCredsDTO)
        {
            throw new NotImplementedException();
        }
    }
}
