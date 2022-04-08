using System.ComponentModel.DataAnnotations;

namespace MasterNet.Models
{
    public class Post
    {
        //introduction over project
        public int Id { get; set; }

        [Required]
        [StringLength(maximumLength:100)]
        public string Title { get; set; }

        [StringLength(maximumLength: 3000)]
        public string Content { get; set; }
        [Range (0,5)]
        public int Score { get; set; }

    }
}
