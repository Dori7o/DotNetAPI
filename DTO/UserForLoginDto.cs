namespace DotNetAPI.DTO {
    public partial class UserForLoginDto
    {
        public string Email {set; get;}

        public string Password {set; get;}


        public UserForLoginDto()
        {
            if (Email == null)
            {
                Email = "";
            }
            if (Password == null)
            {
                Password = "";
            }
        }
    }
}