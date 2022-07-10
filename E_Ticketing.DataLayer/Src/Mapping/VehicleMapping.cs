using E_Ticketing.CoreLayer.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Ticketing.DataLayer.Mapping
{
    public class VehicleMapping : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.ToTable("vehicle");
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).HasColumnName("id");
            builder.Property(e => e.Vehicle_Name).HasColumnName("name");
            builder.Property(e => e.Vehicle_Status).HasColumnName("status");
            builder.Property(e => e.Vehicle_Number).HasColumnName("vehicle_number");

            builder.HasOne<VehicleCategory>(t => t.Vehicle_Category)
              .WithMany(v => v.Vehicles).HasForeignKey(v => v.Vehicle_CategoryId).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
