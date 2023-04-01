namespace DopJope
{
    public class User
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthYear { get; set; }
        public Role Role { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nSurname: {Surname}\nBirthYear {BirthYear}\nRole: {Role}\n";
        }
    }

    public enum Role : int
    {
        User = 0,
        Admin = 1
    }
}
