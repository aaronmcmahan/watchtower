using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Config
{
    public class ComputerConfiguration : IEntityTypeConfiguration<Computer>
    {
        public void Configure(EntityTypeBuilder<Computer> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
               .UseHiLo("computer_hilo")
               .IsRequired();

            // Windows enforces a 15 character hostname limit: http://support.microsoft.com/kb/909264
            builder.Property(c => c.Hostname)
                .IsRequired()
                .HasMaxLength(15);

            builder.HasOne(c => c.Lab)
                .WithMany()
                .HasForeignKey(c => c.LabId);
        }
    }
}
