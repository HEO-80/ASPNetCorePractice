using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        //Foreing Key
        public int? TagId { get; set; }

        [ForeignKey(name: "TagId")]
        public Tag Tag { get; set; }



    }
}
