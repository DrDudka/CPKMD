using CPKMD.Data;
using Npgsql;

namespace CPKMD
{
    public class AuthService(CPKMEDContext context)
    {
        private readonly CPKMEDContext _context = context ?? throw new ArgumentNullException(nameof(context));

        public int AuthUser(string login, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            return user?.Id ?? -1;
        }
    }
}
