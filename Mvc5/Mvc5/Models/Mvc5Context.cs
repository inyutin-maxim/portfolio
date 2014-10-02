using System.Data.Entity;

namespace Mvc5.Models
{
    public class Mvc5Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Mvc5Context() : base("name=Mvc5Context")
        {
        }

		public DbSet<Entities.dynamic_page> dynamic_page {
			get;
			set;
		}
    
    }
}
