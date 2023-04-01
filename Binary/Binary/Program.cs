using System.Text;

string path = "users";

using (FileStream fs = new(path, FileMode.Create))
{
    using BinaryWriter bw = new(fs, Encoding.Default);

    List<User> users = new List<User>()
    {
        new User
        {
            Name = "Елизавета",
            Surname = "Кольцова",
            Patronymic = "Андреевна",
            Age = 18,
            Gender = Gender.Female
        },
        new User
        {
            Name = "Николай",
            Surname = "Мухин",
            Patronymic = "Александрович",
            Age = 32,
            Gender = Gender.Male
        },
        new User
        {
            Name = "Пётр",
            Surname = "Авдеев",
            Patronymic = "Вадимович",
            Age = 18,
            Gender = Gender.Male
        },
        new User
        {
            Name = "Эвелина",
            Surname = "Говнеева",
            Patronymic = "Сашковна",
            Age = 23,
            Gender = Gender.Female
        },
        new User
        {
            Name = "Сергей",
            Surname = "Ботезад",
            Patronymic = "Иванович",
            Age = 24,
            Gender = Gender.Male
        }
    };

    foreach (var user in users)
    {
        bw.Write(user.Name);
        bw.Write(user.Surname);
        bw.Write(user.Patronymic);
        bw.Write(user.Age);
        bw.Write((int)user.Gender);
    }

    bw.Flush();
}

using (FileStream fs = new(path, FileMode.Open))
{
    using BinaryReader br = new(fs, Encoding.Default);

    List<User> readUsers = new();

    while (br.BaseStream.Position < br.BaseStream.Length)
    {
        readUsers.Add(new User
        {
            Name = br.ReadString(),
            Surname = br.ReadString(),
            Patronymic = br.ReadString(),
            Age = br.ReadInt32(),
            Gender = (Gender)br.ReadInt32()
        });
    }

    readUsers.ForEach(user => Console.WriteLine(user.ToString()));
}


public class User
{
    public string Name { get; set; } = null!;
    public string Surname { get; set; } = null!;
    public string Patronymic { get; set; } = null!;
    public int Age { get; set; }
    public Gender Gender { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}\nSurname: {Surname}\nPatronymic: {Patronymic}\n" +
            $"Age: {Age}\nGender: {Gender}\n";
    }
}

public enum Gender
{
    Male,
    Female
}