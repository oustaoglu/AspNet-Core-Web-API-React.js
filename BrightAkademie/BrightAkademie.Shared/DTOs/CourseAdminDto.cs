using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Shared.DTOs
{
    public class CourseAdminDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TotalTime { get; set; }
        public decimal Price { get; set; }
        public string CourseLevel { get; set; }
        public string Earnings { get; set; }
        public string Statues { get; set; }
        public string ImageUrl { get; set; }
        public string TrainerName { get; set; }
        public TrainerDto Trainer { get; set; }
        public CategoryDto Categories { get; set; }
    }
}
