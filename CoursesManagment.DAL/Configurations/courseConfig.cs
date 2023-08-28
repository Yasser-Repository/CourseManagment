using CourseManagment.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagment.DAL.Configurations
{
    public class courseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(crs => crs.Name).HasMaxLength(200);
            builder.Property(crs => crs.trainerId).IsRequired(false);
            builder.Property(crs => crs.Description).IsRequired(false);

        }
    }
}
