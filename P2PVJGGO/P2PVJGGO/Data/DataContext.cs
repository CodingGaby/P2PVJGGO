using P2PVJGGO.Data;
using System.Data.Entity;

namespace P203.Data
{
    public class DataContext : DbContext
    {
        DbSet<City> Cities { get; set; }
        DbSet<Country> Countries { get; set; }
        DbSet<Employee> Employees { get; set; }
        DbSet<Enterprise> Enterprise { get; set; }
        DbSet<User> Users { get; set; }


        #region Constructor

        public DataContext() : base("name=con")
        {
        }

        #endregion
    }
}