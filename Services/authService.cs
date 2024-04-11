using Microsoft.EntityFrameworkCore;
using PetAdoptionProject.Components.Pages;
using PetAdoptionProject.Data;
using System.Linq;
using System.Threading.Tasks;

namespace PetAdoptionProject.Services
{
    public class authService
    {
        private readonly DataContext _dbContext; // Assuming DataContext is your DbContext class

        public authService(DataContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<bool> AuthenticateUserAsync(string email, string password)
        {
            // Retrieve user by email from the database
            var user = await _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);

            if (user != null)
            {
                // Compare the hashed password from the database with the hashed user input password
                if (user.Password == password)
                {
                    // Authentication successful
                    return true;
                }
            }

            // Authentication failed
            return false;
        }
        public async Task<bool> AuthenticateClientAsync(string email, string password)
        {
            // Retrieve user by email from the database
            var client = await _dbContext.Clients.FirstOrDefaultAsync(cl => cl.Email == email);

            if (client != null)
            {
                // Compare the hashed password from the database with the hashed user input password
                if (client.Password == password)
                {
                    // Authentication successful
                    return true;
                }
            }

            // Authentication failed
            return false;
        }
    }
}
