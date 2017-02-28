using System.Data.Entity;
using Server.Data;

namespace Server
{
    public class UserContext : DbContext
    {
        static UserContext()
        {
            Database.SetInitializer<UserContext>(new UserContextInitialiser());
        }

        public UserContext()
            : base("DbConnection")
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<UserHistory> UserHistories { get; set; }
    }
}
