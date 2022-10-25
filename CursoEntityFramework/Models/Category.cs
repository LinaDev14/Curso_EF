using System.ComponentModel.DataAnnotations;

namespace CursoEntityFramework.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayFormat(ConvertEmptyStringToNull = true, NullDisplayText = "[NULL]")]
        public string Name { get; set; }
    }
}
