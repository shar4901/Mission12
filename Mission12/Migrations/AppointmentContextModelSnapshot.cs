﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission12.Models;

namespace Mission12.Migrations
{
    [DbContext(typeof(AppointmentContext))]
    partial class AppointmentContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.22");

            modelBuilder.Entity("Mission12.Models.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("GroupSize")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Phone")
                        .HasColumnType("TEXT");

                    b.HasKey("AppointmentId");

                    b.ToTable("Appointments");

                    b.HasData(
                        new
                        {
                            AppointmentId = 1,
                            Email = "test@test.com",
                            GroupName = "Farquad Squad",
                            GroupSize = 4,
                            Phone = "801-123-1234"
                        });
                });

            modelBuilder.Entity("Mission12.Models.TimeSlot", b =>
                {
                    b.Property<DateTime>("AppointmentDateTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AppointmentId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AppointmentDateTime");

                    b.HasIndex("AppointmentId");

                    b.ToTable("TimeSlots");

                    b.HasData(
                        new
                        {
                            AppointmentDateTime = new DateTime(2022, 4, 5, 8, 0, 0, 0, DateTimeKind.Unspecified),
                            AppointmentId = 1
                        },
                        new
                        {
                            AppointmentDateTime = new DateTime(2022, 4, 5, 9, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Mission12.Models.TimeSlot", b =>
                {
                    b.HasOne("Mission12.Models.Appointment", "Appointment")
                        .WithMany()
                        .HasForeignKey("AppointmentId");
                });
#pragma warning restore 612, 618
        }
    }
}
