namespace WebApplication2.Model
{
    public class ApplicationDbContex : DbContext
    {
        public ApplicationDbContex(DbContextOptions<ApplicationDbContex>options):base(options)
        {
               
        }
    }
}
