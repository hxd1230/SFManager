using System.Data.Entity;
using System.Reflection;

namespace Xiao.D.Data
{
    public class XiaoDbContext : DbContext
    {
        public XiaoDbContext() : base("name=conn") { }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.AddFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
