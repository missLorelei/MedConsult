using MedConsult.Web.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedConsult.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        //public DbSet<Color> Colors { get; set; }
        //public DbSet<Block> Blocks { get; set; }
        //public DbSet<Board> Boards { get; set; }
        //public DbSet<Block> RelatedBlocks { get; set; }
        //public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        //public DbSet<UserBoard> UsersBoards { get; set; }
        //public DbSet<Reference> References { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            //builder.Entity<Block>()
            //    .ToTable("Blocks")
            //   .HasOne(s => s.Board)
            //   .WithMany(d => d.Blocks).OnDelete(DeleteBehavior.Cascade);

            //__________________________________________________________________________________________________________________________________//

            //builder.Entity<Block>()
            //    .ToTable("Blocks").HasOne(b => b.ParentBlock)
            //                      .WithMany(t => t.Children)
            //                      .HasForeignKey("ParentBlockId")
            //                      .IsRequired(false).OnDelete(DeleteBehavior.)
            //                      .HasConstraintName("ForeignKey_ParentBlockId").Equals(builder.Entity<Block>());




            //builder.Entity<Block>().HasMany(b => b.Children)
            //    .WithOne(b => b.ParentBlock)
            //    .IsRequired(false).HasForeignKey(b => b.ParentBlockId);

            // .OnDelete(DeleteBehavior.);


            //            modelBuilder.Entity<Item>().
            //HasMany(p => p.SuppliersItems).
            //WithRequired(a => a.Item).
            //HasForeignKey(a => a.ItemID).WillCascadeOnDelete(false);
            //builder.Entity<Block>()
            //   .HasOne(s => s.ParentBlock)
            //   .WithMany(d => d.Children).OnDelete(DeleteBehavior.Cascade);


            //builder.Entity<Block>()
            //   .WithMany(d => d.Children).OnDelete(DeleteBehavior.Cascade);

            //builder.Entity<Block>()
            //    .HasMany(p => RelatedBlocks)
            //    .WithMany()
            //    .Map(m =>
            //    {
            //        m.MapLeftKey("ProductID");
            //        m.MapRightKey("RelatedID");
            //        m.ToTable("product_related");
            //    });


            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public override void Dispose()
        {
            base.Dispose();
        }
    }
}
