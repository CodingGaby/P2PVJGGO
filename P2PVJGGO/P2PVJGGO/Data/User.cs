namespace P2PVJGGO.Data
{
    public class User
    {
        #region Props

        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Password { get; set; }
        public string Adress { get; set; }

        #endregion

        #region Constructor

        public User(int id, string name, string email, string phoneNumber, string password, string address)
        {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
            Password = password;
            Adress = address;
        }
        #endregion
    }
}
