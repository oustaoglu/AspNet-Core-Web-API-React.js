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
    public class TraineeConfig : IEntityTypeConfiguration<Trainee>
    {
        public void Configure(EntityTypeBuilder<Trainee> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedDate).IsRequired();

            builder.Property(x => x.ModifiedDate).IsRequired();

            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.IsDeleted).IsRequired();

            builder.Property(x => x.FirstName).IsRequired();

            builder.Property(x => x.LastName).IsRequired();

            builder.Property(x => x.Education).IsRequired();

            builder.Property(x => x.Url).IsRequired();

            builder.Property(x => x.PhotoUrl).IsRequired();

            builder.HasData(
               new Trainee
               {
                   Id = 1,
                   FirstName = "Onur",
                   LastName = "Ustaoğlu",
                   Education = ".NET (.NET Core, MVC, Web API)",
                   Url = "onur-ustaoglu",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 2,
                   FirstName = "Serkan",
                   LastName = "Selek",
                   Education = "Java (Spring, Java SE, Java EE)",
                   Url = "serkan-selek",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 3,
                   FirstName = "Furkan",
                   LastName = "Yüksel",
                   Education = "Python",
                   Url = "furkan-yuksel",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 4,
                   FirstName = "Ali",
                   LastName = "Turan",
                   Education = "JavaScript",
                   Url = "ali-turan",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 5,
                   FirstName = "Mert",
                   LastName = "Tutkun",
                   Education = "C/C++",
                   Url = "mert-tutkun",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 6,
                   FirstName = "Alim",
                   LastName = "Yalçınkaya",
                   Education = "iOS & Android",
                   Url = "alim-yalcinkaya",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 7,
                   FirstName = "Uğurcan",
                   LastName = "Çildiz",
                   Education = "Node.js",
                   Url = "ugurcan-cildiz",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 8,
                   FirstName = "Rıdvan",
                   LastName = "Karakaya",
                   Education = "React",
                   Url = "rıdvan-karakaya",
                   PhotoUrl = "1.png",
               });
        }
    }
}
