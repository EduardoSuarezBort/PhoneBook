namespace apiPhoneBook.Models
{
    using System.Data.Entity;

    public class DataContext:DbContext
    {
        public DataContext():base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<apiPhoneBook.Models.Phone> Phones { get; set; }
    }
}