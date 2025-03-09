using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KindergartenArtScoreAPI.Migrations
{
    /// <inheritdoc />
    public partial class RenameColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ClassName",
                table: "Students",
                newName: "class_name");

            migrationBuilder.RenameColumn(
                name: "ArtScore",
                table: "Students",
                newName: "art_score");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 92, "香蕉", "瑾瑜 羅" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "art_score", "Name" },
                values: new object[] { 79, "燁磊 尹" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "art_score", "Name" },
                values: new object[] { 3, "天宇 蘇" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 57, "香蕉", "子軒 董" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "art_score", "Name" },
                values: new object[] { 29, "智宸 袁" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 23, "草莓", "志澤 孔" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 46, "香蕉", "鈺軒 盧" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 24, "蘋果", "昊強 何" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 67, "草莓", "智宸 董" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 54, "香蕉", "子涵 王" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 17, "蘋果", "修潔 黎" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 47, "草莓", "思遠 毛" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 38, "香蕉", "越彬 劉" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 100, "草莓", "鴻濤 蘇" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 29, "草莓", "燁磊 馬" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "art_score", "Name" },
                values: new object[] { 89, "明杰 萬" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 62, "蓮霧", "子騫 秦" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "art_score", "Name" },
                values: new object[] { 5, "雪松 陳" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 57, "蓮霧", "思淼 潘" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 39, "草莓", "浩然 蔣" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 32, "草莓", "博文 白" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 36, "香蕉", "靖琪 韋" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 85, "蓮霧", "振家 曾" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "art_score", "Name" },
                values: new object[] { 23, "偉宸 閻" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "art_score", "Name" },
                values: new object[] { 83, "弘文 蘇" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 34, "蓮霧", "哲瀚 沈" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 16, "香蕉", "燁霖 趙" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 31, "草莓", "正豪 何" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 36, "香蕉", "健雄 方" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 53, "蘋果", "俊馳 顧" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 49, "草莓", "偉祺 姚" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 96, "草莓", "思聰 夏" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 18, "蓮霧", "黎昕 秦" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 48, "蘋果", "思聰 汪" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 28, "草莓", "志澤 劉" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 59, "草莓", "澤洋 郭" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 95, "香蕉", "智輝 龍" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 7, "草莓", "風華 蔡" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "art_score", "Name" },
                values: new object[] { 73, "嘉懿 侯" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "art_score", "class_name", "Name" },
                values: new object[] { 72, "香蕉", "樂駒 莫" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "class_name",
                table: "Students",
                newName: "ClassName");

            migrationBuilder.RenameColumn(
                name: "art_score",
                table: "Students",
                newName: "ArtScore");

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 89, "草莓", "煜城 邵" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ArtScore", "Name" },
                values: new object[] { 52, "炎彬 姜" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ArtScore", "Name" },
                values: new object[] { 22, "博文 何" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 26, "蘋果", "立輝 蔣" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ArtScore", "Name" },
                values: new object[] { 60, "懿軒 陶" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 65, "蘋果", "耀傑 盧" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 82, "蓮霧", "鷺洋 張" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 51, "蓮霧", "燁霖 韋" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 45, "蘋果", "越澤 田" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 31, "蘋果", "越澤 毛" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 69, "草莓", "瑞霖 沈" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 46, "香蕉", "弘文 沈" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 87, "蓮霧", "語堂 徐" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 68, "香蕉", "振家 潘" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 86, "蓮霧", "健柏 於" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ArtScore", "Name" },
                values: new object[] { 82, "思聰 陶" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 10, "香蕉", "語堂 程" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ArtScore", "Name" },
                values: new object[] { 45, "振家 陳" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 86, "香蕉", "子默 丁" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 56, "蘋果", "梓晨 賀" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 68, "蘋果", "偉誠 洪" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 29, "草莓", "修潔 邵" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 35, "香蕉", "紹齊 田" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ArtScore", "Name" },
                values: new object[] { 68, "鈺軒 龔" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ArtScore", "Name" },
                values: new object[] { 5, "楷瑞 廖" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 25, "香蕉", "睿淵 蔡" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 76, "草莓", "志強 許" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 18, "蘋果", "文軒 譚" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 1, "草莓", "君浩 鄭" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 9, "香蕉", "梓晨 朱" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 73, "蓮霧", "智淵 呂" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 17, "蘋果", "胤祥 龔" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 3, "草莓", "弘文 顧" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 82, "草莓", "瑾瑜 宋" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 27, "蘋果", "瑾瑜 蘇" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 29, "香蕉", "曉博 顧" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 84, "草莓", "俊馳 段" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 16, "蘋果", "子默 蘇" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ArtScore", "Name" },
                values: new object[] { 18, "遠航 趙" });

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ArtScore", "ClassName", "Name" },
                values: new object[] { 42, "蘋果", "越澤 董" });
        }
    }
}
