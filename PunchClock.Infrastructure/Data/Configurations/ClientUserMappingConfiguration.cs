using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PunchClock.Database.Domain
{
    public class ClientUserMappingConfiguration : IEntityTypeConfiguration<ClientUserMapping>
    {
        public void Configure(EntityTypeBuilder<ClientUserMapping> builder)
        {
            {
               
                builder.HasKey(x => x.Id);
                builder.HasOne(x => x.Client).WithMany(x => x.ClientUserMapping).HasForeignKey(x => x.ClientId).OnDelete(DeleteBehavior.Cascade); 
                builder.HasOne(x => x.User).WithMany(x => x.ClientUserMapping).HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

            }
        }

    }
}
