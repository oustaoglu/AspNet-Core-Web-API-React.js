using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Shared.DTOs
{
    public class CartItemDto
    {
        public int CartItemId { get; set; }
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string CourseUrl { get; set; }
        public string CourseImageUrl { get; set; }
        public decimal? Price { get; set; }
        [Required(ErrorMessage = "Boş bırakılmalalıdır.")]
        public int Quantity { get; set; }
    }
}
