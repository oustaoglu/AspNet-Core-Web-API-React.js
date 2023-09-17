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
    public class CourseTraineeConfig : IEntityTypeConfiguration<CourseTrainee>
    {
        public void Configure(EntityTypeBuilder<CourseTrainee> builder)
        {
            builder.HasKey(ct => new { ct.CourseId, ct.TraineeId });
            builder.HasData(
                new CourseTrainee { CourseId = 1, TraineeId = 1 },
                new CourseTrainee { CourseId = 2, TraineeId = 1 },
                new CourseTrainee { CourseId = 3, TraineeId = 1 },
                new CourseTrainee { CourseId = 4, TraineeId = 1 },
                new CourseTrainee { CourseId = 5, TraineeId = 1 },
                new CourseTrainee { CourseId = 6, TraineeId = 2 },
                new CourseTrainee { CourseId = 8, TraineeId = 2 },
                new CourseTrainee { CourseId = 9, TraineeId = 2 },
                new CourseTrainee { CourseId = 10, TraineeId = 3 },
                new CourseTrainee { CourseId = 11, TraineeId = 3 },
                new CourseTrainee { CourseId = 12, TraineeId = 3 },
                new CourseTrainee { CourseId = 13, TraineeId = 3 },
                new CourseTrainee { CourseId = 14, TraineeId = 4 },
                new CourseTrainee { CourseId = 15, TraineeId = 4 },
                new CourseTrainee { CourseId = 16, TraineeId = 4 },
                new CourseTrainee { CourseId = 17, TraineeId = 4 },
                new CourseTrainee { CourseId = 18, TraineeId = 5 },
                new CourseTrainee { CourseId = 19, TraineeId = 5 },
                new CourseTrainee { CourseId = 20, TraineeId = 5 },
                new CourseTrainee { CourseId = 21, TraineeId = 5 },
                new CourseTrainee { CourseId = 22, TraineeId = 5 },
                new CourseTrainee { CourseId = 23, TraineeId = 6 },
                new CourseTrainee { CourseId = 24, TraineeId = 6 },
                new CourseTrainee { CourseId = 25, TraineeId = 6 },
                new CourseTrainee { CourseId = 26, TraineeId = 6 },
                new CourseTrainee { CourseId = 27, TraineeId = 7 },
                new CourseTrainee { CourseId = 28, TraineeId = 7 },
                new CourseTrainee { CourseId = 29, TraineeId = 7 },
                new CourseTrainee { CourseId = 30, TraineeId = 8 });
        }
    }
}
