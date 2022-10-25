using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CursoEntityFramework.Models
{
    [Table("Tbl_Article")]
    public class Article
    {
        [Key]
        public int ArticleId { get; set; }
        [Column("Title")]
        [Required(ErrorMessage = "Title is required")]
        [MaxLength(20)]
        public string TitleArticle { get; set; }
        [Required(ErrorMessage = "Description is required")]
        [StringLength(500, ErrorMessage = "Description should not exceed 500 characters")]
        public string Description { get; set; }

        [Range(0.1, 5.0)]
        public double Score { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
