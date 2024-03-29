namespace DotNetAPI.DTO {
    public partial class UserForRegistrationDto
    {
        public string Email {set; get;}

        public string Password {set; get;}

        public string PasswordConfirm {set; get;}

        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Gender {get; set;}

        public string JobTitle {get; set;}
        public string Department {get; set;}
        public decimal Salary {get; set;}

        public UserForRegistrationDto()
        {
            if (Email == null)
            {
                Email = "";
            }
            if (Password == null)
            {
                Password = "";
            }
            if (PasswordConfirm == null)
            {
                PasswordConfirm = "";
            }
            if (FirstName == null)
            {
                FirstName = "";
            }
            if (LastName == null)
            {
                LastName = "";
            }
            if (Gender == null)
            {
                Gender = "";
            }
            if (JobTitle == null)
            {
                JobTitle = "";
            }
            if (Department == null)
            {
                Department = "";
            }
        }
    }
}