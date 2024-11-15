﻿// <auto-generated />
using System;
using ManagementSystem.Persitence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ManagementSystem.Persitence.Migrations
{
    [DbContext(typeof(ManagementSystemDbContext))]
    [Migration("20241114222449_mig1")]
    partial class mig1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ManagementSystem.Domain.Appointment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("AppointmentDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ServiceId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("StatusId");

                    b.HasIndex("UserId");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("ManagementSystem.Domain.AppointmentStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("StatusName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("AppointmentStatuses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5387),
                            StatusName = "Onaylandı"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5395),
                            StatusName = "İptal Edildi"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5397),
                            StatusName = "Tamamlandı"
                        });
                });

            modelBuilder.Entity("ManagementSystem.Domain.Service", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Services");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5463),
                            Name = "Egzoz Gazı Ölçümü"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5464),
                            Name = "Fren Testi"
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5465),
                            Name = "Far Ayarı"
                        });
                });

            modelBuilder.Entity("ManagementSystem.Domain.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("ManagementSystem.Domain.UserRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("UserRoles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5477),
                            RoleName = "Egzoz Gazı Ölçümü"
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2024, 11, 15, 1, 24, 49, 130, DateTimeKind.Local).AddTicks(5478),
                            RoleName = "Fren Testi"
                        });
                });

            modelBuilder.Entity("ManagementSystem.Domain.Appointment", b =>
                {
                    b.HasOne("ManagementSystem.Domain.Service", "Service")
                        .WithMany("Appointments")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManagementSystem.Domain.AppointmentStatus", "Status")
                        .WithMany("Appointments")
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ManagementSystem.Domain.User", "User")
                        .WithMany("Appointments")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("Status");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ManagementSystem.Domain.User", b =>
                {
                    b.HasOne("ManagementSystem.Domain.UserRole", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("ManagementSystem.Domain.AppointmentStatus", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("ManagementSystem.Domain.Service", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("ManagementSystem.Domain.User", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("ManagementSystem.Domain.UserRole", b =>
                {
                    b.Navigation("Users");
                });
#pragma warning restore 612, 618
        }
    }
}