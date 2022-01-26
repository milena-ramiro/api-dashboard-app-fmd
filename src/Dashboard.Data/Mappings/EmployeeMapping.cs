using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dashboard.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Dashboard.Data.Mappings
{
    public class EmployeeMapping : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Team)
                .WithMany(t => t.Employees)
                .HasForeignKey(e => e.TeamId)
                .IsRequired();

            builder.Property(e => e.Name)
                .IsRequired()
                .HasColumnType("varchar(100)");

            builder.Property(e => e.Gender)
                .IsRequired()
                .HasColumnType("varchar(20)");

            builder.Property(e => e.Discord)
                .IsRequired()
                .HasColumnType("nvarchar");

            builder.Property(e => e.Whatsapp)
                .IsRequired()
                .HasColumnType("nvarchar");

            builder.Property(e => e.Email)
                .IsRequired()
                .HasColumnType("nvarchar");


            builder.ToTable("Employee");
        }
    }
}
