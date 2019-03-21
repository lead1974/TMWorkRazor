using TMWork.Data.Core.Domain;
using TMWork.Data.Persistance.EntityConfiguration;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TMWork.Data.Persistance
{
    public class ECDbContext : IdentityDbContext<AuthUser, AuthRole, string>
    {
        public ECDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Contact> Contacts { get; protected set; }
        public virtual DbSet<Invoice> Invoices { get; set; }
        public virtual DbSet<FileUpload> FileUploads { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // Make sure this line in place to avoid "dotnet ef database update" errors!!! 

            modelBuilder.ApplyConfiguration(new ContactConfiguration());

            modelBuilder.Entity<AuthUser>(b => {
                b.HasMany(x => x.Roles).WithOne().HasForeignKey(ur => ur.UserId).IsRequired();
            });

            modelBuilder.Entity<FileUpload>()
                .HasOne(i => i.Invoice)
                .WithMany(i => i.FileUpload)
                .HasForeignKey(i => i.InvoiceId)
                .HasConstraintName("FK_FileUpload_Invoice")
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
