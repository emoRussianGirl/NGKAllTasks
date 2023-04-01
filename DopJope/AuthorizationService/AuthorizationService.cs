namespace DopJope
{
    public class AuthorizationService
    {
        private readonly UserRepository _users;

        public AuthorizationService(UserRepository users)
        {
            _users = users;
        }

        public User Authorize(string name, string surname, int birthYear)
        {
            var user = _users.Get(name, surname, birthYear);

            return user;
        }
    }
}
