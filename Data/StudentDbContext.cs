// Data/StudentDbContext.cs
namespace KindergartenArtScoreAPI.Data  // 加入這行命名空間宣告
{
    using Microsoft.EntityFrameworkCore;
    using KindergartenArtScoreAPI.Models;
    using Bogus;

    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed Data
            string[] classNames = { "草莓", "蘋果", "香蕉", "蓮霧" };
            var faker = new Bogus.Faker<Student>("zh_TW")  // 使用 Bogus.Faker 生成假資料
                .RuleFor(s => s.Name, f => f.Name.FullName())
                .RuleFor(s => s.ClassName, f => f.PickRandom(classNames)) // 從 classNames 陣列中隨機選擇班級名稱
                .RuleFor(s => s.ArtScore, f => f.Random.Number(0, 100)); // 生成 0~100 之間的隨機分數

            List<Student> students = new List<Student>(); // 建立學生物件列表
            int studentIdCounter = 1; //  👈  新增：手動 Id 計數器，宣告並初始化為 1

            foreach (var className in classNames)
            {
                for (int i = 0; i < 10; i++)
                {
                    var student = faker.Generate(); // 生成一個假學生資料
                    student.Id = studentIdCounter++; //  👈  修改：手動設定 Id，並將計數器遞增
                    students.Add(student); // 將生成的假學生資料加入列表
                }
            }

            modelBuilder.Entity<Student>().HasData(students); // 將生成的假學生資料作為 Seed Data 添加

            base.OnModelCreating(modelBuilder);
        }
    }
}