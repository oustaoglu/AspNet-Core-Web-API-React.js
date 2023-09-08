using BrightAkademiApi.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademiApi.Data.Concrete.EFCore.Configs
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
                   Education = "",
                   Url = "",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 2,
                   FirstName = "Serkan",
                   LastName = "Selek",
                   Education = "",
                   Url = "",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 3,
                   FirstName = "Furkan",
                   LastName = "Yüksel",
                   Education = "",
                   Url = "",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 4,
                   FirstName = "Ali",
                   LastName = "Turan",
                   Education = "",
                   Url = "",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 5,
                   FirstName = "Mert",
                   LastName = "Tutkun",
                   Education = "",
                   Url = "",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 6,
                   FirstName = "Alim",
                   LastName = "Yalçınkaya",
                   Education = "",
                   Url = "",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 7,
                   FirstName = "Uğurcan",
                   LastName = "Çildiz",
                   Education = "",
                   Url = "",
                   PhotoUrl = "1.png",
               },
               new Trainee
               {
                   Id = 8,
                   FirstName = "Rıdvan",
                   LastName = "Karakaya",
                   Education = "",
                   Url = "",
                   PhotoUrl = "1.png",
               });
        }
    }
}
