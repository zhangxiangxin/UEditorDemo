using System.ComponentModel.DataAnnotations;

namespace UEditor.Models
{
    public class Post
    {
        [Required(ErrorMessage = "必填")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
    }
}