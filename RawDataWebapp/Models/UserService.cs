using Microsoft.AspNetCore.Identity;
using RawDataWebapp.Models;
using System.Threading.Tasks;

namespace RawDataWebapp.Services
{
    public class UserService
    {
        private readonly AppDbContext _context;
        private readonly PasswordHasher<User> _passwordHasher;

        public UserService(AppDbContext context)
        {
            _context = context;
            _passwordHasher = new PasswordHasher<User>();
        }

        public async Task RegisterUserAsync(User user)
        {
            user.Password = _passwordHasher.HashPassword(user, user.Password);  // Hash the password
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }
    }
}
