using CommentManagement.Domain.CommentAgg;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace CommentManagement.Infrastructure.EFCore.Mapping
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>

    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comments");
            builder.HasKey(X => X.Id);
            builder.Property(x => x.Name).HasMaxLength(255).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(255).IsRequired();
            builder.Property(x => x.WebSite).HasMaxLength(500);
            builder.Property(x => x.Message).HasMaxLength(1000).IsRequired();
            //builder.HasOne(x => x.Parent)
            //    .WithMany(x => x.Children)
            //    .HasForeignKey(x => x.ParentId)
            //    .OnDelete(DeleteBehavior.NoAction);

            //builder.HasMany(x => x.Children)
            //  .WithOne(x => x.Parent)
            //  .HasForeignKey(x => x.ParentId)
            //  .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
