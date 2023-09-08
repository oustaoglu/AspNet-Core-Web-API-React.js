using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BrightAkademiApi.Data.Migrations
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
                name: "Traines",
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
                    table.PrimaryKey("PK_Traines", x => x.Id);
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
                        name: "FK_Courses_Trainers_TrainerId",
                        column: x => x.TrainerId,
                        principalTable: "Trainers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Courses_Traines_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Traines",
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
                        name: "FK_CourseTrainees_Traines_TraineeId",
                        column: x => x.TraineeId,
                        principalTable: "Traines",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedDate", "Description", "IsActive", "IsDeleted", "ModifiedDate", "Name", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7876), "Yazılım geliştirme, bilgisayar programlarının tasarımı, oluşturulması ve sürdürülmesi sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, işlevsellik sağlamak ve teknolojik çözümler üretmek için kodlama, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7886), "Yazılım Geliştime", "yazilim-gelistirme" },
                    { 2, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7890), "Mobil uygulama geliştirme, mobil platformlarda çalışabilen kullanışlı ve etkileşimli yazılım uygulamalarının tasarımı, oluşturulması ve dağıtılması sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, sorunlara çözüm sunmak ve kullanıcı deneyimini geliştirmek için programlama, arayüz tasarımı, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7890), "Mobil Uygulama Geliştirme", "mobil-uygulama-gelistirme" },
                    { 3, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7892), "Oyun geliştirme, video oyunlarının tasarımı, programlaması ve oluşturulması sürecidir. Bu süreç, oyun kavramının belirlenmesi, hikaye yazımı, karakter tasarımı, dünya oluşturma, grafik ve ses tasarımı, oyun mekaniği ve kullanıcı arayüzü gibi aşamaları içerir.", true, false, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7892), "Oyun Geliştime", "oyun-gelistirme" },
                    { 4, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7893), "Web, dünya genelinde bilgilere erişim sağlayan ve kullanıcıların çeşitli hizmetlere bağlanmasını mümkün kılan bir ağdır. Web, HTML, CSS ve JavaScript gibi teknolojilerle oluşturulan web siteleri ve web uygulamaları aracılığıyla çalışır.", true, false, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7893), "Web", "web" },
                    { 5, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7894), "Veritabanı, yapılandırılmış verilerin depolandığı ve yönetildiği bir elektronik sistemdir. Veritabanları, bilgiyi organize etmek, erişmek, güncellemek ve analiz etmek için kullanılır. İşletmeler, kuruluşlar ve web uygulamaları gibi birçok alan veritabanlarını kullanır.", true, false, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7895), "Veritabanı", "veritabani" },
                    { 6, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7896), "DevOps, yazılım geliştirme ve işletim süreçlerini birleştirerek, yazılım projelerinin daha hızlı, güvenilir ve sürekli bir şekilde dağıtılmasını sağlayan bir yaklaşımdır. Bu metodoloji, geliştirme (Development) ve işletim (Operations) ekipleri arasında işbirliği ve iletişimi teşvik eder.", true, false, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7896), "DevOps", "devops" },
                    { 7, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7898), "Bulut, internet üzerinde sunulan paylaşımlı bilgi işlem kaynaklarını ifade eder. Bulut hizmetleri, sunucular, depolama, veritabanları, ağ altyapısı ve uygulama hizmetleri gibi kaynaklara erişimi kolaylaştırır. Kullanıcılar, istedikleri zaman istedikleri yerden bu kaynaklara güvenli bir şekilde erişebilir ve ihtiyaçlarına göre ölçeklendirebilir.", true, false, new DateTime(2023, 9, 8, 18, 55, 55, 227, DateTimeKind.Local).AddTicks(7898), "Bulut", "bulut" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "BirthOfYear", "CreatedDate", "Education", "Evaluation", "Experience", "Field", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9781), "", 1m, "", "", "Dominic", true, false, "Harmon", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9782), "1.png", "" },
                    { 2, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9789), "", 1m, "", "", "Justina", true, false, "Burch", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9789), "1.png", "" },
                    { 3, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1985, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9855), "", 1m, "", "", "Madison", true, false, "Beard", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9856), "1.png", "" },
                    { 4, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9859), "", 1m, "", "", "Sara", true, false, "Wade", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9859), "1.png", "" },
                    { 5, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1988, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9863), "", 1m, "", "", "Jacob", true, false, "Hunt", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9863), "1.png", "" },
                    { 6, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1989, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9865), "", 1m, "", "", "Osamu", true, false, "Dazai", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9866), "1.png", "" },
                    { 7, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1983, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9867), "", 1m, "", "", "Zachery", true, false, "Salas", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9868), "1.png", "" },
                    { 8, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9871), "", 1m, "", "", "Matt", true, false, "Haig", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9872), "1.png", "" },
                    { 9, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9875), "", 1m, "", "", "William", true, false, "Hawkingan", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9875), "1.png", "" },
                    { 10, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9877), "", 1m, "", "", "Geraldine", true, false, "Richmond", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9877), "1.png", "" },
                    { 11, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1983, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9879), "", 1m, "", "", "Steffan", true, false, "Ros", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9879), "1.png", "" },
                    { 12, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1991, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9882), "", 1m, "", "", "Nichole", true, false, "Talley", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9883), "1.png", "" },
                    { 13, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1979, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9884), "", 1m, "", "", "Yetta", true, false, "Sheppard", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9885), "1.png", "" },
                    { 14, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1978, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9886), "", 1m, "", "", "Elijah", true, false, "Farley", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9887), "1.png", "" },
                    { 15, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1991, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9888), "", 1m, "", "", "Neil", true, false, "Wooten", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(9889), "1.png", "" }
                });

            migrationBuilder.InsertData(
                table: "Traines",
                columns: new[] { "Id", "CreatedDate", "Education", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8360), "", "Onur", true, false, "Ustaoğlu", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8362), "1.png", "" },
                    { 2, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8368), "", "Serkan", true, false, "Selek", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8368), "1.png", "" },
                    { 3, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8370), "", "Furkan", true, false, "Yüksel", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8370), "1.png", "" },
                    { 4, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8372), "", "Ali", true, false, "Turan", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8372), "1.png", "" },
                    { 5, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8373), "", "Mert", true, false, "Tutkun", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8373), "1.png", "" },
                    { 6, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8375), "", "Alim", true, false, "Yalçınkaya", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8375), "1.png", "" },
                    { 7, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8377), "", "Uğurcan", true, false, "Çildiz", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8377), "1.png", "" },
                    { 8, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8381), "", "Rıdvan", true, false, "Karakaya", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(8381), "1.png", "" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseLevel", "CreatedDate", "Description", "Earnings", "End", "Evaluation", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "Location", "ModifiedDate", "Name", "Price", "Start", "Statues", "Time", "TotalTime", "TraineeId", "TrainerId", "Url" },
                values: new object[,]
                {
                    { 1, "Easy", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3122), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3131), 5m, "1.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3127), ".NET (.NET Core, MVC, Web API)", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3130), "Tamamlandı.", "4", "200", null, 1, ".net-core-mvc" },
                    { 2, "Easy", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3141), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3143), 5m, "2.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3141), "Java (Spring, Java SE, Java EE)", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3142), "Tamamlandı.", "4", "200", null, 2, "java" },
                    { 3, "Easy", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3146), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3148), 5m, "3.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3146), "Python", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3148), "Tamamlandı.", "4", "200", null, 3, "python" },
                    { 4, "Easy", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3151), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3152), 5m, "4.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3151), "JavaScript", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3152), "Tamamlandı.", "4", "200", null, 4, "javascript" },
                    { 5, "Easy", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3154), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3156), 5m, "5.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3155), "C/C++", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3155), "Açılacak.", "4", "200", null, 5, "c/c++	" },
                    { 6, "Easy", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3158), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3159), 5m, "6.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3158), "iOS & Android", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3159), "Açılacak.", "4", "200", null, 6, "ios-android" },
                    { 7, "Easy", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3161), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3163), 5m, "7.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3162), "React Native", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3163), "Açılacak.", "4", "200", null, 7, "react-native" },
                    { 8, "Easy", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3165), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3166), 5m, "8.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3165), "Flutter", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3166), "Açılacak.", "4", "200", null, 8, "flutter" },
                    { 9, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3169), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3172), 5m, "9.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3169), "Ionic", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3170), "Açılacak.", "4", "200", null, 9, "ionic" },
                    { 10, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3178), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3180), 5m, "10.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3179), "Unity", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3179), "Açılacak.", "4", "200", null, 10, "unity" },
                    { 11, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3182), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3183), 5m, "11.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3182), "Unreal Engine", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3183), "Açılacak.", "4", "200", null, 11, "unreal-engine" },
                    { 12, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3187), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3189), 5m, "12.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3187), "GameMaker Studio", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3188), "Açılacak.", "4", "200", null, 12, "gamemaker-studio" },
                    { 13, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3191), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3192), 5m, "13.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3191), "Buildbox", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3192), "Açılacak.", "4", "200", null, 13, "buildbox" },
                    { 14, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3195), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3197), 5m, "14.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3195), "PHP", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3196), "Açılacak.", "4", "200", null, 14, "php" },
                    { 15, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3199), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3200), 5m, "15.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3199), "React", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3200), "Açılacak.", "4", "200", null, 8, "react" },
                    { 16, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3202), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3204), 5m, "16.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3202), "Angular", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3203), "Açılacak.", "4", "200", null, 9, "angular" },
                    { 17, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3206), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3208), 5m, "17.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3207), "Node.js", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3207), "Açılacak.", "4", "200", null, 10, "nodejs" },
                    { 18, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3210), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3211), 5m, "18.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3210), "Microsoft SQL Server", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3211), "Açılacak.", "4", "200", null, 11, "microsoft-sql-server" },
                    { 19, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3214), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3217), 5m, "19.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3215), "MySQL", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3215), "Açılacak.", "4", "200", null, 12, "mysql" },
                    { 20, "Medium", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3219), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3221), 5m, "20.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3220), "PostgreSQL", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3221), "Açılacak.", "4", "200", null, 13, "postgresql" },
                    { 21, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3223), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3224), 5m, "21.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3223), "SQLite", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3224), "Açılacak.", "4", "200", null, 11, "sqlite" },
                    { 22, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3226), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3228), 5m, "22.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3227), "Oracle", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3228), "Devam Ediyor.", "4", "200", null, 12, "oracle" },
                    { 23, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3230), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3231), 5m, "23.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3230), "Docker", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3231), "Devam Ediyor.", "4", "200", null, 13, "docker" },
                    { 24, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3233), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3235), 5m, "24.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3234), "Jenkins", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3235), "Devam Ediyor.", "4", "200", null, 14, "jenkins" },
                    { 25, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3237), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3239), 5m, "25.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3237), "Ansible", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3239), "Devam Ediyor.", "4", "200", null, 8, "ansible" },
                    { 26, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3242), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3245), 5m, "26.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3242), "Sonarcube", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3243), "Devam Ediyor.", "4", "200", null, 9, "sonarcube" },
                    { 27, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3246), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3248), 5m, "27.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3247), "AWS", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3248), "Devam Ediyor.", "4", "200", null, 10, "aws" },
                    { 28, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3250), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3252), 5m, "28.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3250), "Azure", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3251), "Devam Ediyor.", "4", "200", null, 11, "azure" },
                    { 29, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3290), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3294), 5m, "29.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3292), "Serverless", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3293), "Devam Ediyor.", "4", "200", null, 12, "serverless" },
                    { 30, "Senior", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3296), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3298), 5m, "30.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3297), "Cloud Storage", 100m, new DateTime(2023, 9, 8, 18, 55, 55, 228, DateTimeKind.Local).AddTicks(3297), "Devam Ediyor.", "4", "200", null, 12, "cloudstorage" }
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
                name: "Trainers");

            migrationBuilder.DropTable(
                name: "Traines");
        }
    }
}
