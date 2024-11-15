using ManagementSystem.Domain;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Persitence.Contexts
{
    public class DbInitialzier
    {
        public static void Initialize(ManagementSystemDbContext context)
        {
            // Veritabanını migration ile güncelleme
            context.Database.Migrate();

            // Seed verisi ekleme
            if (!context.AppointmentStatuses.Any())
            {
                context.AppointmentStatuses.AddRange(
                    new AppointmentStatus
                    {
                        Id=1,
                        Appointments = null,
                        StatusName = "Onaylandı",
                        CreateDate = DateTime.Now,
                        UpdateDate=null
                    },
                    new AppointmentStatus
                    {
                        Id=2,
                        StatusName = "İptal Edildi",
                        CreateDate = DateTime.Now,
                        UpdateDate = null
                    },
                    new AppointmentStatus
                    {
                        Id=3,
                        Appointments = null,
                        StatusName = "Tamamlandı",
                        CreateDate = DateTime.Now,
                        UpdateDate = null
                    }
                );
                context.SaveChanges();
            }

            if (!context.Services.Any())
            {
                context.Services.AddRange(
                    new Service
                    {
                        Id = 1,
                        Name = "Egzoz Gazı Ölçümü",
                        CreateDate = DateTime.Now,
                        Appointments=null,
                        UpdateDate = null

                    },
                    new Service
                    {
                        Id = 2, 
                        Name = "Fren Test",
                        CreateDate = DateTime.Now,
                        Appointments = null,
                        UpdateDate = null
                    },
                    new Service
                    {
                        Id = 3,
                        Name = "Far Ayarı",
                        CreateDate = DateTime.Now,
                        Appointments = null,
                        UpdateDate = null
                    }
                );
                context.SaveChanges();
            }

            if (!context.UserRoles.Any())
            {
                context.UserRoles.AddRange(
                    new UserRole
                    {
                        Id=1,
                        RoleName = "Admin",
                        CreateDate = DateTime.Now,
                        UpdateDate = null

                    },
                    new UserRole
                    {
                        Id=2,
                        RoleName = "User",
                        CreateDate = DateTime.Now,
                        UpdateDate = null
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
