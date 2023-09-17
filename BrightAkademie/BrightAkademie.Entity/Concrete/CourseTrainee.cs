using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Entity.Concrete
{
    public class CourseTrainee
    {
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public int TraineeId { get; set; }
        public Trainee Trainee { get; set; }
    }
}
