using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization; // 加入這行命名空間宣告

namespace KindergartenArtScoreAPI.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "學生姓名為必填項")]
        public string Name { get; set; }

        [Required(ErrorMessage = "班級名稱為必填項")]
        [Column("class_name")]
        [JsonPropertyName("class_name")]
        public string ClassName { get; set; }

        [Required(ErrorMessage = "美術成績為必填項")]
        [Range(0, 100, ErrorMessage = "美術成績必須介於 0~100 分之間")]
        [Column("art_score")]
        [JsonPropertyName("art_score")]
        public int ArtScore { get; set; }
    }
}