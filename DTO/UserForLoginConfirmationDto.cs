namespace DotNetAPI.DTO
{
    public partial class UserForLoginConfirmationDto
    {
        public byte[] PasswordHash {get; set;}
        public byte[] PasswordSalt {get; set;}
    

    public UserForLoginConfirmationDto()
    {
        if(PasswordHash == null) {
            PasswordHash = [];
        }
        
        if(PasswordSalt == null) {
            PasswordSalt = [];
        }
    }
}
}