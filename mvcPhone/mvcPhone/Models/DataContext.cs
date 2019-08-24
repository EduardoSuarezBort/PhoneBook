
namespace mvcPhone.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<mvcPhone.Models.Phone> Phones { get; set; }
    }
}