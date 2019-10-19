

namespace appContactSecurity.Models
{
    using System.Data.Entity;

    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<appContactSecurity.Models.Contact> Contacts { get; set; }
    }
}