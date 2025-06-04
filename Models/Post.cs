using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SyncSyntax.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "The title is required")]
        [MaxLength(400, ErrorMessage = "The title can't exceed 400 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "The content is required")]
        public string Content { get; set; }

        [Required(ErrorMessage = "The author is required")]
        [MaxLength(100, ErrorMessage = "The name can't exceed 100 characters")]
        public string Author { get; set; }

        public string FeatureImagePath { get; set; }

        [DataType(DataType.Date)]
        public DateTime PublishedDate { get; set; } = DateTime.Now;

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }
        
        public ICollection<Comment> Comments { get; set; }
    }
}