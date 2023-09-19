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
                    { 1, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7129), "Yazılım geliştirme, bilgisayar programlarının tasarımı, oluşturulması ve sürdürülmesi sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, işlevsellik sağlamak ve teknolojik çözümler üretmek için kodlama, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7141), "Yazılım Geliştime", "yazilim-gelistirme" },
                    { 2, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7144), "Mobil uygulama geliştirme, mobil platformlarda çalışabilen kullanışlı ve etkileşimli yazılım uygulamalarının tasarımı, oluşturulması ve dağıtılması sürecidir. Bu süreç, kullanıcı ihtiyaçlarını karşılamak, sorunlara çözüm sunmak ve kullanıcı deneyimini geliştirmek için programlama, arayüz tasarımı, test etme ve dağıtma adımlarını içerir.", true, false, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7144), "Mobil Uygulama Geliştirme", "mobil-uygulama-gelistirme" },
                    { 3, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7146), "Oyun geliştirme, video oyunlarının tasarımı, programlaması ve oluşturulması sürecidir. Bu süreç, oyun kavramının belirlenmesi, hikaye yazımı, karakter tasarımı, dünya oluşturma, grafik ve ses tasarımı, oyun mekaniği ve kullanıcı arayüzü gibi aşamaları içerir.", true, false, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7146), "Oyun Geliştime", "oyun-gelistirme" },
                    { 4, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7147), "Web, dünya genelinde bilgilere erişim sağlayan ve kullanıcıların çeşitli hizmetlere bağlanmasını mümkün kılan bir ağdır. Web, HTML, CSS ve JavaScript gibi teknolojilerle oluşturulan web siteleri ve web uygulamaları aracılığıyla çalışır.", true, false, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7147), "Web", "web" },
                    { 5, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7148), "Veritabanı, yapılandırılmış verilerin depolandığı ve yönetildiği bir elektronik sistemdir. Veritabanları, bilgiyi organize etmek, erişmek, güncellemek ve analiz etmek için kullanılır. İşletmeler, kuruluşlar ve web uygulamaları gibi birçok alan veritabanlarını kullanır.", true, false, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7149), "Veritabanı", "veritabani" },
                    { 6, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7150), "DevOps, yazılım geliştirme ve işletim süreçlerini birleştirerek, yazılım projelerinin daha hızlı, güvenilir ve sürekli bir şekilde dağıtılmasını sağlayan bir yaklaşımdır. Bu metodoloji, geliştirme (Development) ve işletim (Operations) ekipleri arasında işbirliği ve iletişimi teşvik eder.", true, false, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7150), "DevOps", "devops" },
                    { 7, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7151), "Bulut, internet üzerinde sunulan paylaşımlı bilgi işlem kaynaklarını ifade eder. Bulut hizmetleri, sunucular, depolama, veritabanları, ağ altyapısı ve uygulama hizmetleri gibi kaynaklara erişimi kolaylaştırır. Kullanıcılar, istedikleri zaman istedikleri yerden bu kaynaklara güvenli bir şekilde erişebilir ve ihtiyaçlarına göre ölçeklendirebilir.", true, false, new DateTime(2023, 9, 18, 18, 27, 47, 577, DateTimeKind.Local).AddTicks(7151), "Bulut", "bulut" }
                });

            migrationBuilder.InsertData(
                table: "Trainees",
                columns: new[] { "Id", "CreatedDate", "Education", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8144), ".NET (.NET Core, MVC, Web API)", "Onur", true, false, "Ustaoğlu", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8148), "1.png", "onur-ustaoglu" },
                    { 2, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8151), "Java (Spring, Java SE, Java EE)", "Serkan", true, false, "Selek", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8151), "1.png", "serkan-selek" },
                    { 3, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8153), "Python", "Furkan", true, false, "Yüksel", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8154), "1.png", "furkan-yuksel" },
                    { 4, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8155), "JavaScript", "Ali", true, false, "Turan", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8155), "1.png", "ali-turan" },
                    { 5, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8156), "C/C++", "Mert", true, false, "Tutkun", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8157), "1.png", "mert-tutkun" },
                    { 6, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8158), "iOS & Android", "Alim", true, false, "Yalçınkaya", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8158), "1.png", "alim-yalcinkaya" },
                    { 7, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8159), "Node.js", "Uğurcan", true, false, "Çildiz", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8160), "1.png", "ugurcan-cildiz" },
                    { 8, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8161), "React", "Rıdvan", true, false, "Karakaya", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(8161), "1.png", "rıdvan-karakaya" }
                });

            migrationBuilder.InsertData(
                table: "Trainers",
                columns: new[] { "Id", "About", "BirthOfYear", "CreatedDate", "Education", "Evaluation", "Experience", "Field", "FirstName", "IsActive", "IsDeleted", "LastName", "ModifiedDate", "PhotoUrl", "Url" },
                values: new object[,]
                {
                    { 1, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9483), "", 1m, "", "", "Dominic", true, false, "Harmon", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9484), "1.png", "" },
                    { 2, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9490), "", 1m, "", "", "Justina", true, false, "Burch", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9490), "1.png", "" },
                    { 3, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1985, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9493), "", 1m, "", "", "Madison", true, false, "Beard", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9493), "1.png", "" },
                    { 4, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9495), "", 1m, "", "", "Sara", true, false, "Wade", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9495), "1.png", "" },
                    { 5, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1988, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9497), "", 1m, "", "", "Jacob", true, false, "Hunt", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9497), "1.png", "" },
                    { 6, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1989, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9499), "", 1m, "", "", "Osamu", true, false, "Dazai", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9499), "1.png", "" },
                    { 7, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1983, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9501), "", 1m, "", "", "Zachery", true, false, "Salas", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9501), "1.png", "" },
                    { 8, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9503), "", 1m, "", "", "Matt", true, false, "Haig", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9503), "1.png", "" },
                    { 9, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1982, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9505), "", 1m, "", "", "William", true, false, "Hawkingan", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9505), "1.png", "" },
                    { 10, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1990, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9507), "", 1m, "", "", "Geraldine", true, false, "Richmond", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9508), "1.png", "" },
                    { 11, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1983, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9509), "", 1m, "", "", "Steffan", true, false, "Ros", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9510), "1.png", "" },
                    { 12, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1991, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9511), "", 1m, "", "", "Nichole", true, false, "Talley", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9512), "1.png", "" },
                    { 13, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1979, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9513), "", 1m, "", "", "Yetta", true, false, "Sheppard", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9514), "1.png", "" },
                    { 14, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1978, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9515), "", 1m, "", "", "Elijah", true, false, "Farley", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9516), "1.png", "" },
                    { 15, "Yazılım eğitimi, modern teknolojinin temelini oluşturan önemli bir süreçtir. Katılımcılara yazılım geliştirme süreçlerinde bilgi ve beceriler kazandırır.", 1991, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9517), "", 1m, "", "", "Neil", true, false, "Wooten", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(9518), "1.png", "" }
                });

            migrationBuilder.InsertData(
                table: "Courses",
                columns: new[] { "Id", "CourseLevel", "CreatedDate", "Description", "Earnings", "End", "Evaluation", "ImageUrl", "IsActive", "IsDeleted", "IsHome", "Location", "ModifiedDate", "Name", "Price", "Start", "Statues", "Time", "TotalTime", "TraineeId", "TrainerId", "Url" },
                values: new object[,]
                {
                    { 1, "Easy", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2959), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2970), 5m, "1.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2965), ".NET (.NET Core, MVC, Web API)", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2969), "Tamamlandı.", "4", "200", null, 1, ".net-core-mvc" },
                    { 2, "Easy", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2976), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2978), 5m, "2.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2976), "Java (Spring, Java SE, Java EE)", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2977), "Tamamlandı.", "4", "200", null, 2, "java" },
                    { 3, "Easy", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2982), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2985), 5m, "3.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2982), "Python", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2984), "Tamamlandı.", "4", "200", null, 3, "python" },
                    { 4, "Easy", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2988), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2990), 5m, "4.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2988), "JavaScript", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2989), "Tamamlandı.", "4", "200", null, 4, "javascript" },
                    { 5, "Easy", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2992), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2995), 5m, "5.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2993), "C/C++", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2994), "Açılacak.", "4", "200", null, 5, "c/c++	" },
                    { 6, "Easy", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2997), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2999), 5m, "6.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2997), "iOS & Android", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(2998), "Açılacak.", "4", "200", null, 6, "ios-android" },
                    { 7, "Easy", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3001), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3003), 5m, "7.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3001), "React Native", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3002), "Açılacak.", "4", "200", null, 7, "react-native" },
                    { 8, "Easy", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3005), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3008), 5m, "8.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3006), "Flutter", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3007), "Açılacak.", "4", "200", null, 8, "flutter" },
                    { 9, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3010), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3012), 5m, "9.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3010), "Ionic", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3011), "Açılacak.", "4", "200", null, 9, "ionic" },
                    { 10, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3014), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3016), 5m, "10.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3014), "Unity", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3015), "Açılacak.", "4", "200", null, 10, "unity" },
                    { 11, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3018), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3020), 5m, "11.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3019), "Unreal Engine", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3020), "Açılacak.", "4", "200", null, 11, "unreal-engine" },
                    { 12, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3023), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3025), 5m, "12.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3023), "GameMaker Studio", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3024), "Açılacak.", "4", "200", null, 12, "gamemaker-studio" },
                    { 13, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3027), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3029), 5m, "13.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3027), "Buildbox", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3028), "Açılacak.", "4", "200", null, 13, "buildbox" },
                    { 14, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3031), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3033), 5m, "14.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3032), "PHP", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3033), "Açılacak.", "4", "200", null, 14, "php" },
                    { 15, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3036), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3038), 5m, "15.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3036), "React", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3037), "Açılacak.", "4", "200", null, 8, "react" },
                    { 16, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3040), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3042), 5m, "16.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3040), "Angular", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3041), "Açılacak.", "4", "200", null, 9, "angular" },
                    { 17, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3044), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3047), 5m, "17.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3045), "Node.js", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3046), "Açılacak.", "4", "200", null, 10, "nodejs" },
                    { 18, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3049), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3051), 5m, "18.jpg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3049), "Microsoft SQL Server", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3050), "Açılacak.", "4", "200", null, 11, "microsoft-sql-server" },
                    { 19, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3053), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3056), 5m, "19.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3053), "MySQL", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3055), "Açılacak.", "4", "200", null, 12, "mysql" },
                    { 20, "Medium", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3058), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3060), 5m, "20.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3058), "PostgreSQL", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3059), "Açılacak.", "4", "200", null, 13, "postgresql" },
                    { 21, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3062), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3064), 5m, "21.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3062), "SQLite", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3063), "Açılacak.", "4", "200", null, 11, "sqlite" },
                    { 22, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3067), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3069), 5m, "22.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3067), "Oracle", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3068), "Devam Ediyor.", "4", "200", null, 12, "oracle" },
                    { 23, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3071), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3073), 5m, "23.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3071), "Docker", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3072), "Devam Ediyor.", "4", "200", null, 13, "docker" },
                    { 24, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3075), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3078), 5m, "24.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3076), "Jenkins", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3077), "Devam Ediyor.", "4", "200", null, 14, "jenkins" },
                    { 25, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3080), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3082), 5m, "25.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3080), "Ansible", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3081), "Devam Ediyor.", "4", "200", null, 8, "ansible" },
                    { 26, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3084), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3086), 5m, "26.jpeg", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3084), "Sonarcube", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3086), "Devam Ediyor.", "4", "200", null, 9, "sonarcube" },
                    { 27, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3089), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3091), 5m, "27.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3089), "AWS", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3090), "Devam Ediyor.", "4", "200", null, 10, "aws" },
                    { 28, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3093), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3095), 5m, "28.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3093), "Azure", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3094), "Devam Ediyor.", "4", "200", null, 11, "azure" },
                    { 29, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3097), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3100), 5m, "29.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3098), "Serverless", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3099), "Devam Ediyor.", "4", "200", null, 12, "serverless" },
                    { 30, "Senior", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3102), "Yazılım dersi, bilgisayar bilimlerinin önemli bir alanıdır ve öğrencilere temel bilgisayar programlama, algoritma oluşturma, veri yapıları, yazılım mühendisliği ve uygulama geliştirme konularında bilgi sağlar. Bu ders, öğrencilere problem çözme becerileri kazandırarak mantıksal düşünce ve analitik yeteneklerini geliştirir. Yazılım dersi aynı zamanda modern teknoloji dünyasında önemli bir role sahip olan yazılım süreçlerini, proje yönetimini ve test etme yöntemlerini de kapsar. Öğrenciler, çeşitli programlama dilleri ve yazılım araçlarını kullanarak uygulamalar geliştirerek pratik deneyim elde eder. Bu ders, gelecekteki teknoloji liderleri ve yazılım geliştiricileri için temel bir adımdır.", "Kod Yazma", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3104), 5m, "30.png", true, false, true, "Barbaros Bulvarı Yıldız İş Hanı No: 9 Kat: 3 Beşiktaş - İstanbul", new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3102), "Cloud Storage", 100m, new DateTime(2023, 9, 18, 18, 27, 47, 578, DateTimeKind.Local).AddTicks(3103), "Devam Ediyor.", "4", "200", null, 12, "cloudstorage" }
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
