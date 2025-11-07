using Business_Layer_BL_.DTOS.UserCredsDTO.F_RetriveUserCredsDTO;
using Business_Layer_BL_.DTOS.UserCredsDTO.F_UpdateUserCredsDTO;
using Business_Layer_BL_.DTOS.UserDTOS.F_UserInsertDTO;
using Business_Layer_BL_.DTOS.UserDTOS.F_UserRetriveDTO;
using Shared.Enums.Operationstatus;

namespace Business_Layer_BL_.Services.F_UserServices.Interfaces
{
    public interface IUserServices
    {
        Task<OperationStatusEnum> InsertUser(InsertUserDTO insertUserDTO);
        Task<OperationStatusEnum> UpdateUser(UpdateUserCredsDTO updateUserCredsDTO);
        Task<OperationStatusEnum> RetrieveUser(UserRetriveDTO userRetriveDTO);
    }
}
