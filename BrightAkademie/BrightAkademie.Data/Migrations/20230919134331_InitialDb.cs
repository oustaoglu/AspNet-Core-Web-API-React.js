using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BrightAkademie.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: false),
                    Adress = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: false),
                    Information = table.Column<string>(type: "TEXT", nullable: false),
                    Questions = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Education = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainees", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Trainers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    BirthOfYear = table.Column<int>(type: "INTEGER", nullable: false),
                    Education = table.Column<string>(type: "TEXT", nullable: false),
                    Experience = table.Column<string>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    About = table.Column<string>(type: "TEXT", nullable: false),
                    PhotoUrl = table.Column<string>(type: "TEXT", nullable: false),
                    Field = table.Column<string>(type: "TEXT", nullable: false),
                    Evaluation = table.Column<decimal>(type: "TEXT", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trainers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TotalTime = table.Column<string>(type: "TEXT", nullable: false),
                    Time = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    Start = table.Column<DateTime>(type: "TEXT", nullable: false),
                    End = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsHome = table.Column<bool>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    CourseLevel = table.Column<string>(type: "TEXT", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Earnings = table.Column<string>(type: "TEXT", nullable: false),
                    Statues = table.Column<string>(type: "TEXT", nullable: false),
                    Evaluation = table.Column<decimal>(type: "TEXT", nullable: false),
                    Url = table.Column<string>(type: "TEXT", nullable: false),
                    ImageUrl = table.Column<string>(type: "TEXT", nullable: false),
                    TrainerId = table.Column<int>(type: "INTEGER", nullable: true),
                    TraineeId = table.Column<int>(type: "INTEGER", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    IsActive = table.Column<bool>(type: "INTEGER", nullable: false),
                    IsDeleted = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Courses_Trainees_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Trainees",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CoursesCategories",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CoursesCategories", x => new { x.CourseId, x.CategoryId });
                    table.ForeignKey(
                        name: "FK_CoursesCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CoursesCategories_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseTrainees",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "INTEGER", nullable: false),
                    TraineeId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseTrainees", x => new { x.CourseId, x.TraineeId });
                    table.ForeignKey(
                        name: "FK_CourseTrainees_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CourseTrainees_Trainees_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Trainees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6624), "Yazılım geliştirme, bilgisayar programlarının tasarımı, oluşturulması ve sürdürülmesi sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, işlevsellik sağlamak ve teknolojik çözümler üretmek için kodlama, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6637), "Yazılım Geliştime", "yazilim-gelistirme" },
                    { 2, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6640), "Mobil uygulama geliştirme, mobil platformlarda çalışabilen kullanışlı ve etkileşimli yazılım uygulamalarının tasarımı, oluşturulması ve dağıtılması sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, sorunlara çözüm sunmak ve kullanıcı deneyimini geliştirmek için programlama, arayüz tasarımı, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6641), "Mobil Uygulama Geliştirme", "mobil-uygulama-gelistirme" },
                    { 3, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6642), "Oyun geliştirme, video oyunlarının tasarımı, programlaması ve oluşturulması sürecidir. Bu süreç, oyun kavramının belirlenmesi, hikaye yazımı, karakter tasarımı, dünya oluşturma, grafik ve ses tasarımı, oyun mekaniği ve kullanıcı arayüzü gibi aşamaları içerir.", true, false, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6642), "Oyun Geliştime", "oyun-gelistirme" },
                    { 4, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6643), "Web, dünya genelinde bilgilere erişim sağlayan ve kullanıcıların çeşitli hizmetlere bağlanmasını mümkün kılan bir ağdır. Web, HTML, CSS ve JavaScript gibi teknolojilerle oluşturulan web siteleri ve web uygulamaları aracılığıyla çalışır.", true, false, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6643), "Web", "web" },
                    { 5, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6644), "Veritabanı, yapılandırılmış verilerin depolandığı ve yönetildiği bir elektronik sistemdir. Veritabanları, bilgiyi organize etmek, erişmek, güncellemek ve analiz etmek için kullanılır. İşletmeler, kuruluşlar ve web uygulamaları gibi birçok alan veritabanlarını kullanır.", true, false, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6644), "Veritabanı", "veritabani" },
                    { 6, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6645), "DevOps, yazılım geliştirme ve işletim süreçlerini birleştirerek, yazılım projelerinin daha hızlı, güvenilir ve sürekli bir şekilde dağıtılmasını sağlayan bir yaklaşımdır. Bu metodoloji, geliştirme (Development) ve işletim (Operations) ekipleri arasında işbirliği ve iletişimi teşvik eder.", true, false, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6645), "DevOps", "devops" },
                    { 7, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6646), "Bulut, internet üzerinde sunulan paylaşımlı bilgi işlem kaynaklarını ifade eder. Bulut hizmetleri, sunucular, depolama, veritabanları, ağ altyapısı ve uygulama hizmetleri gibi kaynaklara erişimi kolaylaştırır. Kullanıcılar, istedikleri zaman istedikleri yerden bu kaynaklara güvenli bir şekilde erişebilir ve ihtiyaçlarına göre ölçeklendirebilir.", true, false, new DateTime(2023, 9, 19, 16, 43, 31, 452, DateTimeKind.Local).AddTicks(6646), "Bulut", "bulut" }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "Id", "About", "Adress", "CompanyName", "CreatedDate", "Information", "IsActive", "IsDeleted", "ModifiedDate", "Questions" },
                values: new object[] { 1, "Eğitim", "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", "Bright Akademie", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(3886), "Eğitim", true, false, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(3889), "Eğitim" });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "CreatedDate", "Education", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5021), ".NET (.NET Core, MVC, Web API)", "Onur", true, false, "Ustaoğlu", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5023), "1.png", "onur-ustaoglu" },
                    { 2, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5025), "Java (Spring, Java SE, Java EE)", "Serkan", true, false, "Selek", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5026), "1.png", "serkan-selek" },
                    { 3, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5027), "Python", "Furkan", true, false, "Yüksel", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5028), "1.png", "furkan-yuksel" },
                    { 4, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5029), "JavaScript", "Ali", true, false, "Turan", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5029), "1.png", "ali-turan" },
                    { 5, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5030), "C/C++", "Mert", true, false, "Tutkun", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5030), "1.png", "mert-tutkun" },
                    { 6, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5031), "iOS & Android", "Alim", true, false, "Yalçınkaya", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5032), "1.png", "alim-yalcinkaya" },
                    { 7, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5033), "Node.js", "Uğurcan", true, false, "Çildiz", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5033), "1.png", "ugurcan-cildiz" },
                    { 8, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5034), "React", "Rıdvan", true, false, "Karakaya", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(5034), "1.png", "rıdvan-karakaya" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "BirthOfYear", "CreatedDate", "Education", "Evaluation", "Experience", "Field", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6181), "", 1m, "", "", "Dominic", true, false, "Harmon", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6182), "1.png", "" },
                    { 2, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6187), "", 1m, "", "", "Justina", true, false, "Burch", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6187), "1.png", "" },
                    { 3, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1985, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6190), "", 1m, "", "", "Madison", true, false, "Beard", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6190), "1.png", "" },
                    { 4, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6191), "", 1m, "", "", "Sara", true, false, "Wade", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6192), "1.png", "" },
                    { 5, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1988, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6193), "", 1m, "", "", "Jacob", true, false, "Hunt", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6193), "1.png", "" },
                    { 6, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1989, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6195), "", 1m, "", "", "Osamu", true, false, "Dazai", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6195), "1.png", "" },
                    { 7, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1983, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6197), "", 1m, "", "", "Zachery", true, false, "Salas", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6197), "1.png", "" },
                    { 8, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6198), "", 1m, "", "", "Matt", true, false, "Haig", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6199), "1.png", "" },
                    { 9, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6200), "", 1m, "", "", "William", true, false, "Hawkingan", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6200), "1.png", "" },
                    { 10, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6202), "", 1m, "", "", "Geraldine", true, false, "Richmond", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6202), "1.png", "" },
                    { 11, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1983, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6203), "", 1m, "", "", "Steffan", true, false, "Ros", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6204), "1.png", "" },
                    { 12, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1991, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6205), "", 1m, "", "", "Nichole", true, false, "Talley", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6205), "1.png", "" },
                    { 13, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1979, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6207), "", 1m, "", "", "Yetta", true, false, "Sheppard", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6207), "1.png", "" },
                    { 14, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1978, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6208), "", 1m, "", "", "Elijah", true, false, "Farley", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6209), "1.png", "" },
                    { 15, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1991, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6210), "", 1m, "", "", "Neil", true, false, "Wooten", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(6210), "1.png", "" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseLevel", "CreatedDate", "Description", "Earnings", "End", "Evaluation", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "Location", "ModifiedDate", "Name", "Price", "Start", "Statues", "Time", "TotalTime", "TraineeId", "TrainerId", "Url" },
                values: new object[,]
                {
                    { 1, "Easy", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(658), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(667), 5m, "1.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(662), ".NET (.NET Core, MVC, Web API)", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(667), "Tamamlandı.", "4", "200", null, 1, ".net-core-mvc" },
                    { 2, "Easy", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(673), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(675), 5m, "2.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(674), "Java (Spring, Java SE, Java EE)", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(675), "Tamamlandı.", "4", "200", null, 2, "java" },
                    { 3, "Easy", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(678), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(679), 5m, "3.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(678), "Python", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(679), "Tamamlandı.", "4", "200", null, 3, "python" },
                    { 4, "Easy", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(681), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(682), 5m, "4.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(681), "JavaScript", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(682), "Tamamlandı.", "4", "200", null, 4, "javascript" },
                    { 5, "Easy", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(684), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(686), 5m, "5.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(685), "C/C++", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(685), "Açılacak.", "4", "200", null, 5, "c/c++	" },
                    { 6, "Easy", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(687), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(689), 5m, "6.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(688), "iOS & Android", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(688), "Açılacak.", "4", "200", null, 6, "ios-android" },
                    { 7, "Easy", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(690), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(692), 5m, "7.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(691), "React Native", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(691), "Açılacak.", "4", "200", null, 7, "react-native" },
                    { 8, "Easy", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(694), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(695), 5m, "8.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(694), "Flutter", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(694), "Açılacak.", "4", "200", null, 8, "flutter" },
                    { 9, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(697), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(699), 5m, "9.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(697), "Ionic", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(699), "Açılacak.", "4", "200", null, 9, "ionic" },
                    { 10, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(701), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(702), 5m, "10.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(701), "Unity", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(702), "Açılacak.", "4", "200", null, 10, "unity" },
                    { 11, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(704), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(705), 5m, "11.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(704), "Unreal Engine", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(705), "Açılacak.", "4", "200", null, 11, "unreal-engine" },
                    { 12, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(707), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(708), 5m, "12.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(707), "GameMaker Studio", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(708), "Açılacak.", "4", "200", null, 12, "gamemaker-studio" },
                    { 13, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(710), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(711), 5m, "13.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(710), "Buildbox", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(711), "Açılacak.", "4", "200", null, 13, "buildbox" },
                    { 14, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(713), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(714), 5m, "14.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(713), "PHP", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(714), "Açılacak.", "4", "200", null, 14, "php" },
                    { 15, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(717), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(719), 5m, "15.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(717), "React", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(718), "Açılacak.", "4", "200", null, 8, "react" },
                    { 16, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(720), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(721), 5m, "16.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(720), "Angular", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(721), "Açılacak.", "4", "200", null, 9, "angular" },
                    { 17, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(723), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(725), 5m, "17.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(723), "Node.js", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(724), "Açılacak.", "4", "200", null, 10, "nodejs" },
                    { 18, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(726), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(728), 5m, "18.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(727), "Microsoft SQL Server", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(727), "Açılacak.", "4", "200", null, 11, "microsoft-sql-server" },
                    { 19, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(729), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(731), 5m, "19.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(730), "MySQL", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(730), "Açılacak.", "4", "200", null, 12, "mysql" },
                    { 20, "Medium", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(732), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(734), 5m, "20.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(733), "PostgreSQL", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(733), "Açılacak.", "4", "200", null, 13, "postgresql" },
                    { 21, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(737), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(738), 5m, "21.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(737), "SQLite", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(738), "Açılacak.", "4", "200", null, 11, "sqlite" },
                    { 22, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(740), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(741), 5m, "22.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(740), "Oracle", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(741), "Devam Ediyor.", "4", "200", null, 12, "oracle" },
                    { 23, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(743), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(744), 5m, "23.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(743), "Docker", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(744), "Devam Ediyor.", "4", "200", null, 13, "docker" },
                    { 24, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(746), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(747), 5m, "24.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(746), "Jenkins", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(747), "Devam Ediyor.", "4", "200", null, 14, "jenkins" },
                    { 25, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(749), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(750), 5m, "25.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(749), "Ansible", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(750), "Devam Ediyor.", "4", "200", null, 8, "ansible" },
                    { 26, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(752), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(753), 5m, "26.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(752), "Sonarcube", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(753), "Devam Ediyor.", "4", "200", null, 9, "sonarcube" },
                    { 27, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(755), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(756), 5m, "27.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(755), "AWS", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(756), "Devam Ediyor.", "4", "200", null, 10, "aws" },
                    { 28, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(758), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(759), 5m, "28.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(758), "Azure", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(759), "Devam Ediyor.", "4", "200", null, 11, "azure" },
                    { 29, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(761), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(762), 5m, "29.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(761), "Serverless", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(762), "Devam Ediyor.", "4", "200", null, 12, "serverless" },
                    { 30, "Senior", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(764), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(765), 5m, "30.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(764), "Cloud Storage", 100m, new DateTime(2023, 9, 19, 16, 43, 31, 453, DateTimeKind.Local).AddTicks(765), "Devam Ediyor.", "4", "200", null, 12, "cloudstorage" }
                });

            migrationBuilder.InsertData(
                table: "CourseTrainees",
                columns: new[] { "CourseId", "TraineeId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 2 },
                    { 8, 2 },
                    { 9, 2 },
                    { 10, 3 },
                    { 11, 3 },
                    { 12, 3 },
                    { 13, 3 },
                    { 14, 4 },
                    { 15, 4 },
                    { 16, 4 },
                    { 17, 4 },
                    { 18, 5 },
                    { 19, 5 },
                    { 20, 5 },
                    { 21, 5 },
                    { 22, 5 },
                    { 23, 6 },
                    { 24, 6 },
                    { 25, 6 },
                    { 26, 6 },
                    { 27, 7 },
                    { 28, 7 },
                    { 29, 7 },
                    { 30, 8 }
                });

            migrationBuilder.InsertData(
                table: "CoursesCategories",
                columns: new[] { "CategoryId", "CourseId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 2, 6 },
                    { 2, 8 },
                    { 2, 9 },
                    { 3, 10 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 4, 14 },
                    { 4, 15 },
                    { 4, 16 },
                    { 4, 17 },
                    { 5, 18 },
                    { 5, 19 },
                    { 5, 20 },
                    { 5, 21 },
                    { 5, 22 },
                    { 6, 23 },
                    { 6, 24 },
                    { 6, 25 },
                    { 6, 26 },
                    { 7, 27 },
                    { 7, 28 },
                    { 7, 29 },
                    { 7, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TraineeId",
                table: "Courses",
                column: "TraineeId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TrainerId",
                table: "Courses",
                column: "TrainerId");

            migrationBuilder.CreateIndex(
                name: "IX_CoursesCategories_CategoryId",
                table: "CoursesCategories",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseTrainees_TraineeId",
                table: "CourseTrainees",
                column: "TraineeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CoursesCategories");

            migrationBuilder.DropTable(
                name: "CourseTrainees");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Trainees");

            migrationBuilder.DropTable(
                name: "Trainers");
        }
    }
}
