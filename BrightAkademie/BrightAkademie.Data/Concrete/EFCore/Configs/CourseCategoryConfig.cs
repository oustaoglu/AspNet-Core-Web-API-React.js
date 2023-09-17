using BrightAkademie.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Data.Concrete.EFCore.Configs
{
    public class CourseCategoryConfig : IEntityTypeConfiguration<CourseCategory>
    {
        public void Configure(EntityTypeBuilder<CourseCategory> builder)
        {
            builder.HasKey(cc => new { cc.CourseId, cc.CategoryId });
            builder.HasData(
                new CourseCategory { CourseId = 1, CategoryId = 1 },
                new CourseCategory { CourseId = 2, CategoryId = 1 },
                new CourseCategory { CourseId = 3, CategoryId = 1 },
                new CourseCategory { CourseId = 4, CategoryId = 1 },
                new CourseCategory { CourseId = 5, CategoryId = 1 },
                new CourseCategory { CourseId = 6, CategoryId = 2 },
                new CourseCategory { CourseId = 8, CategoryId = 2 },
                new CourseCategory { CourseId = 9, CategoryId = 2 },
                new CourseCategory { CourseId = 10, CategoryId = 3 },
                new CourseCategory { CourseId = 11, CategoryId = 3 },
                new CourseCategory { CourseId = 12, CategoryId = 3 },
                new CourseCategory { CourseId = 13, CategoryId = 3 },
                new CourseCategory { CourseId = 14, CategoryId = 4 },
                new CourseCategory { CourseId = 15, CategoryId = 4 },
                new CourseCategory { CourseId = 16, CategoryId = 4 },
                new CourseCategory { CourseId = 17, CategoryId = 4 },
                new CourseCategory { CourseId = 18, CategoryId = 5 },
                new CourseCategory { CourseId = 19, CategoryId = 5 },
                new CourseCategory { CourseId = 20, CategoryId = 5 },
                new CourseCategory { CourseId = 21, CategoryId = 5 },
                new CourseCategory { CourseId = 22, CategoryId = 5 },
                new CourseCategory { CourseId = 23, CategoryId = 6 },
                new CourseCategory { CourseId = 24, CategoryId = 6 },
                new CourseCategory { CourseId = 25, CategoryId = 6 },
                new CourseCategory { CourseId = 26, CategoryId = 6 },
                new CourseCategory { CourseId = 27, CategoryId = 7 },
                new CourseCategory { CourseId = 28, CategoryId = 7 },
                new CourseCategory { CourseId = 29, CategoryId = 7 },
                new CourseCategory { CourseId = 30, CategoryId = 7 });
        }
    }
}
