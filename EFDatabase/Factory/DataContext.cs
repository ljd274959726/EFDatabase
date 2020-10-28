using System.Data.Entity;
using EFDatabase.Entity;

namespace EFDatabase.Factory
{
    [DbConfigurationType(typeof(MySql.Data.EntityFramework.MySqlEFConfiguration))]
    public class DataContext : DbContext
    {
        private const string ConnectionString =
            "Data Source=localhost;port=3306;Initial Catalog=ljd;user id=root;password=Bb123456;";

        public DbSet<Student> Students { get; set; }

        public DataContext() : base(ConnectionString)
        {

        }
    }
}