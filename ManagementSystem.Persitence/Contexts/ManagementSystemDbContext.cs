using ManagementSystem.Domain;
using ManagementSystem.Domain.Common;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Persitence.Contexts
{
    public class ManagementSystemDbContext : IdentityDbContext<User, UserRole, Guid>
    {
        public ManagementSystemDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<AppointmentStatus> AppointmentStatuses { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityUserLogin<Guid>>()
                .HasKey(login => new { login.LoginProvider, login.ProviderKey });

            modelBuilder.Entity<IdentityUserRole<Guid>>()
                .HasKey(userRole => new { userRole.UserId, userRole.RoleId });

            modelBuilder.Entity<IdentityUserToken<Guid>>()
                .HasKey(token => new { token.UserId, token.LoginProvider, token.Name });

            modelBuilder.Entity<AppointmentStatus>()
                .HasData(
                new AppointmentStatus() { Id = Guid.NewGuid(), Appointments = null, StatusName = "Onaylandı", CreateDate = DateTime.Now, UpdateDate = null },
                new AppointmentStatus() { Id = Guid.NewGuid(), Appointments = null, StatusName = "İptal Edildi", CreateDate = DateTime.Now, UpdateDate = null },
                new AppointmentStatus() { Id = Guid.NewGuid(), Appointments = null, StatusName = "Tamamlandı", CreateDate = DateTime.Now, UpdateDate = null }
                );

            modelBuilder.Entity<Service>()
              .HasData(
              new Service() { Id = Guid.NewGuid(), Appointments = null, Name = "Egzoz Gazı Ölçümü", CreateDate = DateTime.Now, UpdateDate = null },
              new Service() { Id = Guid.NewGuid(), Appointments = null, Name = "Fren Testi", CreateDate = DateTime.Now, UpdateDate = null },
              new Service() { Id = Guid.NewGuid(), Appointments = null, Name = "Far Ayarı", CreateDate = DateTime.Now, UpdateDate = null }
              );
            //modelBuilder.Entity<UserRole>()
            //.HasData(
            //new UserRole() { Id = "1", Name = "Admin" },
            //new UserRole() { Id = "2", Name = "User" }
            //);

        }
        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var datas = ChangeTracker.Entries<BaseEntity>();
            //var users = ChangeTracker.Entries<User>();
            //if (EntityState.Added is EntityState.Added)
            //{
            //    foreach (var us in users)
            //    {
            //        us.Entity.RoleId = 2;
            //    }
            //}
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
