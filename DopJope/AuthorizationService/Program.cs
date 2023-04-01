namespace DopJope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Инициализация начальными данными в случае их отсутствия
            List<User> allUsers = new List<User>()
            {
                new User()
                {
                    Name = "Вася",
                    Surname = "Мухин",
                    BirthYear = 1990,
                    Role = Role.User
                },
                new User()
                {
                    Name = "Петя",
                    Surname = "Романов",
                    BirthYear = 2000,
                    Role = Role.User
                },
                new User()
                {
                    Name = "Вадим",
                    Surname = "Коновалов",
                    BirthYear = 1995,
                    Role = Role.Admin
                }
            };

            UserRepository users = new UserRepository("users.txt");
            AuthorizationService authorizationService = new AuthorizationService(users);

            if (!File.Exists("users.txt"))
            {
                File.Create("users.txt").Dispose();

                if (File.ReadAllLines("users.txt").Length < 3)
                {
                    foreach (var user in allUsers)
                    {
                        users.Add(user);
                    }
                }
            }

            //Сама программа
            string command = string.Empty;
            User currentUser = null;

            while (command != "exit")
            {
                Console.WriteLine("Введите номер операции. Для выхода \"exit\".");
                Console.WriteLine("1 Авторизация.\n2 Список пользователей\n3 Удаление пользователя");

                command = Console.ReadLine()!;

                switch (command)
                {
                    case "1":
                        Console.WriteLine("Вход.");

                        Console.WriteLine("Введите имя пользователя:");
                        string name = Console.ReadLine();

                        Console.WriteLine("Введите фамилию:");
                        string surname = Console.ReadLine();

                        Console.WriteLine("Введите год рождения:");
                        int year = int.Parse(Console.ReadLine());

                        var user = authorizationService.Authorize(name, surname, year);

                        if (user != null)
                        {
                            Console.WriteLine("Вход успешен. Добрый день.");
                            currentUser = user;
                        }
                        else
                        {
                            Console.WriteLine("Неавторизован.");
                        }

                        break;

                    case "2":
                        if (currentUser != null && currentUser.Role == Role.Admin) 
                        {
                            var getAllUsers = users.GetAll();

                            for (int i = 0; i < getAllUsers.Count; i++)
                            {
                                Console.WriteLine($"{i}.{getAllUsers[i]}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно прав. Войдите под администратором.");
                        }

                        break;

                    case "3":
                        if (currentUser != null && currentUser.Role == Role.Admin)
                        {
                            Console.WriteLine("Введите номер пользователя.");
                            int num = int.Parse(Console.ReadLine());

                            var result = users.Delete(num);

                            Console.WriteLine($"Успех: {result}");
                        }
                        else
                        {
                            Console.WriteLine("Недостаточно прав. Войдите под администратором.");
                        }
                        break;

                    case "exit":
                        Console.WriteLine("Выход..");
                        break;

                    case "clear":
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine("Нераспознанная команда.");
                        break;
                }
            }
        }
    }
}