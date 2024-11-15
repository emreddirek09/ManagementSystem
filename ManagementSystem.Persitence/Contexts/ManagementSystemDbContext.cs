using ManagementSystem.Domain;
using ManagementSystem.Domain.Common;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementSystem.Persitence.Contexts
{
    public class ManagementSystemDbContext : DbContext
    {
        public ManagementSystemDbContext(DbContextOptions<ManagementSystemDbContext> options)
        : base(options)
        {
        }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppointmentStatus>()
                .HasData(
                new AppointmentStatus() { Id = 1, Appointments = null, StatusName = "Onaylandı", CreateDate = DateTime.Now, UpdateDate = null },
                new AppointmentStatus() { Id = 2, Appointments = null, StatusName = "İptal Edildi", CreateDate = DateTime.Now, UpdateDate = null },
                new AppointmentStatus() { Id = 3, Appointments = null, StatusName = "Tamamlandı", CreateDate = DateTime.Now, UpdateDate = null }
                );

            modelBuilder.Entity<Service>()
              .HasData(
              new Service() { Id = 1, Appointments = null, Name = "Egzoz Gazı Ölçümü", CreateDate = DateTime.Now, UpdateDate = null },
              new Service() { Id = 2, Appointments = null, Name = "Fren Testi", CreateDate = DateTime.Now, UpdateDate = null },
              new Service() { Id = 3, Appointments = null, Name = "Far Ayarı", CreateDate = DateTime.Now, UpdateDate = null }
              );
            modelBuilder.Entity<UserRole>()
            .HasData(
            new UserRole() { Id = 1, RoleName = "Admin", CreateDate = DateTime.Now, UpdateDate = null },
            new UserRole() { Id = 2, RoleName = "User", CreateDate = DateTime.Now, UpdateDate = null }
            );

        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();

            foreach (var data in datas)
            {
                _ = data.State switch
                {
                    EntityState.Added => data.Entity.CreateDate = DateTime.Now,
                    EntityState.Modified => data.Entity.UpdateDate = DateTime.Now

                };
            }

            return await base.SaveChangesAsync(cancellationToken);

        }
    }
}
