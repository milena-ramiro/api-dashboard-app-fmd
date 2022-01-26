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
    public class TeamMapping : IEntityTypeConfiguration<Team>
    {
        public void Configure(EntityTypeBuilder<Team> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Title)
                .IsRequired()
                .HasColumnType("varchar(50)");

            builder.Property(t => t.Description)
                .IsRequired()
                .HasColumnType("nvarchar");

            builder.Property(t => t.Theme)
                .IsRequired()
                .HasColumnType("varchar(50)");


            builder.ToTable("Team");
        }
    }
}
