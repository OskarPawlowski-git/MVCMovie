using Microsoft.EntityFrameworkCore;

namespace MvcMovie.Models
{
    public class ClientModel : DbContext
    {
        public ClientModel (DbContextOptions<ClientModel> options)
            : base(options)
        {
        }

        public DbSet<MvcMovie.Models.Client> Client { get; set; }
    }
}