using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public interface IApplicationContext
    {
        public DbSet<BeerDatabaseModel> Beers { get; set; }
    }
}
