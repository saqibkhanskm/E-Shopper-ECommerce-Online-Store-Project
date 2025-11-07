namespace Business_Layer_BL_.DTOS.UserCredsDTO.F_UpdateUserCredsDTO
{
    public class UpdateUserCredsDTO
    {
        public Guid CredsId { get; set; }
        public Guid UserId { get; set; }
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
    }
}
