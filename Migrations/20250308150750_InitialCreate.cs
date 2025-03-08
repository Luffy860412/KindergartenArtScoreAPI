using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace KindergartenArtScoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    ClassName = table.Column<string>(type: "TEXT", nullable: false),
                    ArtScore = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "ArtScore", "ClassName", "Name" },
                values: new object[,]
                {
                    { 1, 89, "草莓", "煜城 邵" },
                    { 2, 52, "草莓", "炎彬 姜" },
                    { 3, 22, "香蕉", "博文 何" },
                    { 4, 26, "蘋果", "立輝 蔣" },
                    { 5, 60, "草莓", "懿軒 陶" },
                    { 6, 65, "蘋果", "耀傑 盧" },
                    { 7, 82, "蓮霧", "鷺洋 張" },
                    { 8, 51, "蓮霧", "燁霖 韋" },
                    { 9, 45, "蘋果", "越澤 田" },
                    { 10, 31, "蘋果", "越澤 毛" },
                    { 11, 69, "草莓", "瑞霖 沈" },
                    { 12, 46, "香蕉", "弘文 沈" },
                    { 13, 87, "蓮霧", "語堂 徐" },
                    { 14, 68, "香蕉", "振家 潘" },
                    { 15, 86, "蓮霧", "健柏 於" },
                    { 16, 82, "草莓", "思聰 陶" },
                    { 17, 10, "香蕉", "語堂 程" },
                    { 18, 45, "蘋果", "振家 陳" },
                    { 19, 86, "香蕉", "子默 丁" },
                    { 20, 56, "蘋果", "梓晨 賀" },
                    { 21, 68, "蘋果", "偉誠 洪" },
                    { 22, 29, "草莓", "修潔 邵" },
                    { 23, 35, "香蕉", "紹齊 田" },
                    { 24, 68, "香蕉", "鈺軒 龔" },
                    { 25, 5, "香蕉", "楷瑞 廖" },
                    { 26, 25, "香蕉", "睿淵 蔡" },
                    { 27, 76, "草莓", "志強 許" },
                    { 28, 18, "蘋果", "文軒 譚" },
                    { 29, 1, "草莓", "君浩 鄭" },
                    { 30, 9, "香蕉", "梓晨 朱" },
                    { 31, 73, "蓮霧", "智淵 呂" },
                    { 32, 17, "蘋果", "胤祥 龔" },
                    { 33, 3, "草莓", "弘文 顧" },
                    { 34, 82, "草莓", "瑾瑜 宋" },
                    { 35, 27, "蘋果", "瑾瑜 蘇" },
                    { 36, 29, "香蕉", "曉博 顧" },
                    { 37, 84, "草莓", "俊馳 段" },
                    { 38, 16, "蘋果", "子默 蘇" },
                    { 39, 18, "蓮霧", "遠航 趙" },
                    { 40, 42, "蘋果", "越澤 董" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
