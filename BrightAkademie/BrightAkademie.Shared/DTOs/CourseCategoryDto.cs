using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Shared.DTOs
{
    public class CourseCategoryDto
    {
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
