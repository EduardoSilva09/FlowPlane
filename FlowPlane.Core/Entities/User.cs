namespace FlowPlane.Core.Entities
{
    public class User : BaseEntity
    {
        public User(string fullName, string email, DateTime birthDate, string password, string role)
        {
            this.FullName = fullName;
            this.Email = email;
            this.BirthDate = birthDate;
            this.CreatedAt = DateTime.Now;
            this.Active = true;
            this.Role = role;
            this.Password = password;
            this.Activities = [];
        }
        public string FullName { get; private set; }
        public string Email { get; private set; }
        public DateTime BirthDate { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public bool Active { get; set; }
        public string Password { get; private set; }
        public string Role { get; private set; }
        public List<Activity> Activities { get; private set; }
    }
}