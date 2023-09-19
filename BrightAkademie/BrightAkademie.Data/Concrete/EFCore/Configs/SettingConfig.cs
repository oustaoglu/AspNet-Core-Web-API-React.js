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
    public class SettingConfig : IEntityTypeConfiguration<Setting>
    {
        public void Configure(EntityTypeBuilder<Setting> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedDate).IsRequired();

            builder.Property(x => x.ModifiedDate).IsRequired();

            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.IsDeleted).IsRequired();

            builder.Property(x => x.CompanyName).IsRequired();

            builder.Property(x => x.Adress).IsRequired();

            builder.Property(x => x.About).IsRequired();

            builder.Property(x => x.Information).IsRequired();

            builder.Property(x => x.Questions).IsRequired();

            builder.HasData(
               new Setting
               {
                   Id = 1,
                   CompanyName = "Bright Akademie",
                   Adress = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                   About = "Eğitim",
                   Information = "Eğitim",
                   Questions = "Eğitim",
               });
        }
    }
}
