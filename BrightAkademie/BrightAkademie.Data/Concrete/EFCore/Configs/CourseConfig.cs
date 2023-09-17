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
    public class CourseConfig : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.CreatedDate).IsRequired();

            builder.Property(x => x.ModifiedDate).IsRequired();

            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.IsDeleted).IsRequired();

            builder.Property(x => x.Name).IsRequired();

            builder.Property(x => x.TotalTime).IsRequired();

            builder.Property(x => x.Time).IsRequired();

            builder.Property(x => x.Price).IsRequired();

            builder.Property(x => x.Start).IsRequired();

            builder.Property(x => x.End).IsRequired();

            builder.Property(x => x.IsHome).IsRequired();

            builder.Property(x => x.Description).IsRequired();

            builder.Property(x => x.CourseLevel).IsRequired();

            builder.Property(x => x.Location).IsRequired();

            builder.Property(x => x.Earnings).IsRequired();

            builder.Property(x => x.Statues).IsRequired();

            builder.Property(x => x.Evaluation).IsRequired();

            builder.Property(x => x.Url).IsRequired();

            builder.Property(x => x.ImageUrl).IsRequired();

            builder.HasData(
                new Course
                {
                    Id = 1,
                    Name = ".NET (.NET Core, MVC, Web API)",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = ".net-core-mvc",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Easy",
                    ImageUrl = "1.jpg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Tamamlandı.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 1
                },
                new Course
                {
                    Id = 2,
                    Name = "Java (Spring, Java SE, Java EE)",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "java",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Easy",
                    ImageUrl = "2.jpg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Tamamlandı.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 2
                },
                new Course
                {
                    Id = 3,
                    Name = "Python",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "python",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Easy",
                    ImageUrl = "3.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Tamamlandı.",
                    Price = 100,
                    Time = "4",
                    Evaluation = 5,
                    IsHome = true,
                    TrainerId = 3
                },
                new Course
                {
                    Id = 4,
                    Name = "JavaScript",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "javascript",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Easy",
                    ImageUrl = "4.jpeg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Tamamlandı.",
                    Price = 100,
                    Time = "4",
                    Evaluation = 5,
                    IsHome = true,
                    TrainerId = 4
                },
                new Course
                {
                    Id = 5,
                    Name = "C/C++",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "c/c++	",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Easy",
                    ImageUrl = "5.jpg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Price = 100,
                    Time = "4",
                    Evaluation = 5,
                    IsHome = true,
                    TrainerId = 5
                },
                new Course
                {
                    Id = 6,
                    Name = "iOS & Android",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "ios-android",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Easy",
                    ImageUrl = "6.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Price = 100,
                    Time = "4",
                    Evaluation = 5,
                    IsHome = true,
                    TrainerId = 6
                },
                new Course
                {
                    Id = 7,
                    Name = "React Native",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "react-native",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Easy",
                    ImageUrl = "7.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 7
                },
                new Course
                {
                    Id = 8,
                    Name = "Flutter",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "flutter",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Easy",
                    ImageUrl = "8.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 8
                },
                new Course
                {
                    Id = 9,
                    Name = "Ionic",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "ionic",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "9.jpg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 9
                },
                new Course
                {
                    Id = 10,
                    Name = "Unity",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "unity",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "10.jpeg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 10
                },
                new Course
                {
                    Id = 11,
                    Name = "Unreal Engine",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "unreal-engine",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "11.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 11
                },
                new Course
                {
                    Id = 12,
                    Name = "GameMaker Studio",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "gamemaker-studio",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "12.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 12
                },
                new Course
                {
                    Id = 13,
                    Name = "Buildbox",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "buildbox",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "13.jpeg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 13
                },
                new Course
                {
                    Id = 14,
                    Name = "PHP",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "php",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "14.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 14
                },
                new Course
                {
                    Id = 15,
                    Name = "React",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "react",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "15.jpeg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 8
                },
                new Course
                {
                    Id = 16,
                    Name = "Angular",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "angular",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "16.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 9
                },
                new Course
                {
                    Id = 17,
                    Name = "Node.js",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "nodejs",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "17.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 10
                },
                new Course
                {
                    Id = 18,
                    Name = "Microsoft SQL Server",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "microsoft-sql-server",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "18.jpg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 11
                },
                new Course
                {
                    Id = 19,
                    Name = "MySQL",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "mysql",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "19.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 12
                },
                new Course
                {
                    Id = 20,
                    Name = "PostgreSQL",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "postgresql",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Medium",
                    ImageUrl = "20.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 13
                },
                new Course
                {
                    Id = 21,
                    Name = "SQLite",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "sqlite",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "21.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Açılacak.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 11
                },
                new Course
                {
                    Id = 22,
                    Name = "Oracle",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "oracle",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "22.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 12
                },
                new Course
                {
                    Id = 23,
                    Name = "Docker",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "docker",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "23.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 13
                },
                new Course
                {
                    Id = 24,
                    Name = "Jenkins",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "jenkins",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "24.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 14
                },
                new Course
                {
                    Id = 25,
                    Name = "Ansible",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "ansible",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "25.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 8
                },
                new Course
                {
                    Id = 26,
                    Name = "Sonarcube",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "sonarcube",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "26.jpeg",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 9
                },
                new Course
                {
                    Id = 27,
                    Name = "AWS",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "aws",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "27.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 10
                },
                new Course
                {
                    Id = 28,
                    Name = "Azure",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "azure",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "28.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 11
                },
                new Course
                {
                    Id = 29,
                    Name = "Serverless",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "serverless",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "29.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 12
                },
                new Course
                {
                    Id = 30,
                    Name = "Cloud Storage",
                    TotalTime = "200",
                    Description = "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.",
                    Url = "cloudstorage",
                    Start = DateTime.Now,
                    End = DateTime.Now,
                    CourseLevel = "Senior",
                    ImageUrl = "30.png",
                    Location = "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul",
                    Earnings = "Kod Yazma",
                    Statues = "Devam Ediyor.",
                    Evaluation = 5,
                    Price = 100,
                    Time = "4",
                    IsHome = true,
                    TrainerId = 12
                });
        }
    }
}
