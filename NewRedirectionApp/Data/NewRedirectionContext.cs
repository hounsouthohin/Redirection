using Microsoft.EntityFrameworkCore;

namespace NewRedirectionApp.Data
{
    public partial class NewRedirectionContext : DbContext
    {


        public NewRedirectionContext()
        {
        }
        public NewRedirectionContext(DbContextOptions<NewRedirectionContext> options)
            : base(options)
        {
        }
    }
}
    

    

        
   
