using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Shared.DTOs
{
    public class CourseTraineeDto
    {
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
        public int TraineeId { get; set; }
        public TraineeDto Trainee { get; set; }
    }
}
