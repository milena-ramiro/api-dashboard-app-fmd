﻿// <auto-generated />
using Dashboard.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Dashboard.Data.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Dashboard.Business.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Discord")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Discord");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Email");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Gender");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Name");

                    b.Property<int>("TeamId")
                        .HasColumnType("int")
                        .HasColumnName("TeamId");

                    b.Property<string>("Whatsapp")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Whatsapp");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Employee");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "male",
                            Name = "Renan - Zica",
                            TeamId = 1,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 2,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "male",
                            Name = "Vitão",
                            TeamId = 1,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 3,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "female",
                            Name = "Camila",
                            TeamId = 1,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 4,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "male",
                            Name = "Barba",
                            TeamId = 1,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 5,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "female",
                            Name = "Milena",
                            TeamId = 2,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 6,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "male",
                            Name = "Irineu",
                            TeamId = 2,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 7,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "male",
                            Name = "Renatox",
                            TeamId = 3,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 8,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "female",
                            Name = "Raelle",
                            TeamId = 3,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 9,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "male",
                            Name = "Aaron Roger",
                            TeamId = 4,
                            Whatsapp = "https://www.google.com.br"
                        },
                        new
                        {
                            Id = 10,
                            Discord = "https://www.google.com.br",
                            Email = "https://www.google.com.br",
                            Gender = "female",
                            Name = "Lisa Simpson",
                            TeamId = 4,
                            Whatsapp = "https://www.google.com.br"
                        });
                });

            modelBuilder.Entity("Dashboard.Business.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Description");

                    b.Property<string>("Theme")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Theme");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Title");

                    b.HasKey("Id");

                    b.ToTable("Team");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Theme = "primary",
                            Title = "Frontend"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Theme = "danger",
                            Title = "Backend"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Theme = "warning",
                            Title = "Design"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry.",
                            Theme = "secondary",
                            Title = "Comercial"
                        });
                });

            modelBuilder.Entity("Dashboard.Business.Models.Employee", b =>
                {
                    b.HasOne("Dashboard.Business.Models.Team", "Team")
                        .WithMany("Employees")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Team");
                });

            modelBuilder.Entity("Dashboard.Business.Models.Team", b =>
                {
                    b.Navigation("Employees");
                });
#pragma warning restore 612, 618
        }
    }
}
