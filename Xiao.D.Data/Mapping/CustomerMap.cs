using System.Data.Entity.ModelConfiguration;
using Xiao.D.Core.Domain.Customers;

namespace Xiao.D.Data.Mapping
{
    public class CustomerMap : EntityTypeConfiguration<Customer>
    {
        public CustomerMap()
        {
            this.ToTable("Customer");
            this.HasKey(c => c.Id);
            this.Property(c => c.UserName).HasMaxLength(16).IsRequired();
            this.Property(c => c.Password).HasMaxLength(32).IsRequired();
        }
    }
}
