using System.Text;

namespace DopJope
{
    //Класс для работы с данными пользователей.
    public class UserRepository
    {
        public readonly string Path;

        public UserRepository(string path)
        {
            Path = path;
        }

        public User Get(int num)
        {
            var users = GetAll();

            return users[num];
        }

        public User Get(string username, string usersurname, int userbirthYear)
        {
            using StreamReader sr = new(Path, Encoding.Default);
            User? getUser = null;

            while (sr.Peek() != -1)
            {
                User user = new User();

                string name = sr.ReadLine();
                user.Name = name;

                string surname = sr.ReadLine();
                user.Surname = surname;

                int year = int.Parse(sr.ReadLine());
                user.BirthYear = year;

                Role role = Enum.Parse<Role>(sr.ReadLine());
                user.Role = role;

                if (user.Name == username && user.Surname == usersurname && user.BirthYear == userbirthYear)
                {
                    getUser = user;
                }
            }

            return getUser;
        }

        public List<User> GetAll()
        {
            using StreamReader sr = new(Path, Encoding.Default);
            List<User> users = new List<User>();

            while (sr.Peek() != -1)
            {
                User user = new User();

                string name = sr.ReadLine();
                user.Name = name;

                string surname = sr.ReadLine();
                user.Surname = surname;

                int year = int.Parse(sr.ReadLine());
                user.BirthYear = year;

                Role role = Enum.Parse<Role>(sr.ReadLine());
                user.Role = role;

                users.Add(user);
            }

            return users;
        }

        public void Add(User user)
        {
            using StreamWriter sw = new(Path, true);
            
            sw.WriteLine(user.Name);
            sw.WriteLine(user.Surname);
            sw.WriteLine(user.BirthYear);
            sw.WriteLine(user.Role);
        }

        public bool Delete(int num)
        {
            var users = GetAll();
            var oldLength = users.Count();

            users.RemoveAt(num);

            WriteAll(users);

            return oldLength < users.Count();
        }

        private void WriteAll(List<User> users)
        {
            using StreamWriter sw = new(Path, false);

            foreach (var user in users)
            {
                sw.WriteLine(user.Name);
                sw.WriteLine(user.Surname);
                sw.WriteLine(user.BirthYear);
                sw.WriteLine(user.Role);
            }
        }
    }
}
