using BrightAkademie.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Entity.Concrete
{
    public class Setting : BaseEntity
    {
        public string CompanyName { get; set; }
        public string Adress { get; set; }
        public string About { get; set; }
        public string Information { get; set; }
        public string Questions { get; set; }
    }
}
