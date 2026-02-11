namespace ComputergyAPI.Entities
{
    public class Person : MainEntity
    {
        //focus on properties and constructor, functionality in Services Class
        
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string? Phone { get; set; }

        public string? Nationality { get; set; }

        public string? Address { get; set; }

        public string? ProfileImage { get; set; }

        public DateTime? LastLoginTime { get; set; }

        public bool IsLoggedIn { get; set; } = false;
    }
}
