using BrightAkademie.Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAkademie.Data.Concrete.EFCore.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void SeedData(this ModelBuilder modelBuilder)
        {
            #region Rol Bilgileri
            List<Role> roles = new List<Role>
            {
                new Role { Name = "SuperAdmin", Description = "Yöneticilerin rolü bu.", NormalizedName = "SUPERADMIN" },
                new Role { Name = "Admin", Description = "Yöneticilerin rolü bu.", NormalizedName = "ADMIN" },
                new Role { Name = "User", Description = "Diğer tüm kullanıcıların rolü bu.", NormalizedName = "USER" },
                new Role { Name = "Trainer", Description = "Eğitmenlerin rolü bu.", NormalizedName = "TRAINER" },
                new Role { Name = "Trainee", Description = "Eğitilenlerin rolü bu.", NormalizedName = "TRAINEE" }
            };
            modelBuilder.Entity<Role>().HasData(roles);
            #endregion

            #region Kullanıcı Bilgileri
            var passwordHasher = new PasswordHasher<User>();
            var users = new List<User>
            {
                new User
                {
                    Id = "1", // User ID eklemeyi unutmayın
                    FirstName = "Onur",
                    LastName = "Ustaoğlu",
                    UserName = "superadmin",
                    NormalizedUserName = "SUPERADMIN",
                    Email = "onrustaoglu@gmail.com",
                    NormalizedEmail = "ONRUSTAOGLU@GMAIL.COM",
                    Gender = "Erkek",
                    DateOfBirth = new DateTime(1995, 2, 3),
                    Address = "Göztepe Mahallesi. 2366 Sk. No:7 D:56 Bağcılar",
                    City = "İstanbul",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(), // Rastgele bir güvenlik damgası oluşturun
                    LockoutEnabled = true,
                    PhoneNumber = "+905445324889",
                    PhoneNumberConfirmed = true,
                    // Diğer özelliklerinizi buraya ekleyin
                },
                new User
                {
                    Id = "2", // User ID eklemeyi unutmayın
                    FirstName = "Serkan",
                    LastName = "Selek",
                    UserName = "admin",
                    NormalizedUserName = "ADMIN",
                    Email = "serkanselek334@gmail.com",
                    NormalizedEmail = "SERKANSELEK34@GMAIL.COM",
                    Gender = "Erkek",
                    DateOfBirth = new DateTime(1995, 9, 10),
                    Address = "Radar Sokak K:2 D:7 Bahçelievler",
                    City = "İstanbul",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(), // Rastgele bir güvenlik damgası oluşturun
                    LockoutEnabled = true,
                    PhoneNumber = "+904596677888",
                    PhoneNumberConfirmed = true,
                    // Diğer özelliklerinizi buraya ekleyin
                },
                new User
                {
                    Id = "3", // User ID eklemeyi unutmayın
                    FirstName = "Eğitmen",
                    LastName = "Eğitmen Soyadı",
                    UserName = "trainer",
                    NormalizedUserName = "TRAINER",
                    Email = "trainer@gmail.com",
                    NormalizedEmail = "TRAINER@GMAIL.COM",
                    Gender = "Erkek",
                    DateOfBirth = new DateTime(1980, 5, 15),
                    Address = "Eğitmen Adresi",
                    City = "İstanbul",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(), // Rastgele bir güvenlik damgası oluşturun
                    LockoutEnabled = true,
                    PhoneNumber = "+901234567890",
                    PhoneNumberConfirmed = true,
                    // Diğer özelliklerinizi buraya ekleyin
                },
                new User
                {
                    Id = "4", // User ID eklemeyi unutmayın
                    FirstName = "Eğitilen",
                    LastName = "Eğitilen Soyadı",
                    UserName = "trainee",
                    NormalizedUserName = "TRAINEE",
                    Email = "trainee@gmail.com",
                    NormalizedEmail = "TRAINEE@GMAIL.COM",
                    Gender = "Kadın",
                    DateOfBirth = new DateTime(1995, 3, 20),
                    Address = "Eğitilen Adresi",
                    City = "Ankara",
                    EmailConfirmed = true,
                    SecurityStamp = Guid.NewGuid().ToString(), // Rastgele bir güvenlik damgası oluşturun
                    LockoutEnabled = true,
                    PhoneNumber = "+901234567891",
                    PhoneNumberConfirmed = true,
                    // Diğer özelliklerinizi buraya ekleyin
                }
            };

            foreach (var user in users)
            {
                user.PasswordHash = passwordHasher.HashPassword(user, "Qwe123.");
            }

            modelBuilder.Entity<User>().HasData(users);
            #endregion

            #region Kullanıcı Rollerini Atama
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>
            {
                new IdentityUserRole<string> { UserId = "1", RoleId = roles[0].Id }, // SuperAdmin
                new IdentityUserRole<string> { UserId = "2", RoleId = roles[1].Id }, // Admin
                new IdentityUserRole<string> { UserId = "3", RoleId = roles[3].Id }, // Trainer
                new IdentityUserRole<string> { UserId = "4", RoleId = roles[4].Id }  // Trainee
            };
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
            #endregion
        }
    }
}
