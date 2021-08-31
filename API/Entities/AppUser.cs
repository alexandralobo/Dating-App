namespace API.Entities
{
    public class AppUser
    {
        public int Id { get; set; } // it will recognised as PK [Id or ID]

        public string UserName { get; set; }

        public byte[] PasswordHash { get; set; }

        public byte[] PasswordSalt { get; set; }

    }
}