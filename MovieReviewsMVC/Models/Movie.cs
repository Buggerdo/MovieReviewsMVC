using System.ComponentModel.DataAnnotations;

namespace MovieReviewsMVC.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }
        
        [StringLength(30, MinimumLength = 3)]
        public string? Genre { get; set; }
        
        [Range(1, 300)]
        public int? Runtime { get; set; }
        
        [StringLength(30)]
        public string? ParentalRating { get; set; }
        
        [StringLength(60, MinimumLength = 3)]
        public string? Director { get; set; }
    }
}
// Scaffold-DbContext 'Data Source=TROYSPC;Initial Catalog=MovieReviewsMvc;Integrated Security=SSPI;' Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
// add-migration MovieReviewsMvc
