using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyPay.API.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(30)]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public double Balance { get; set; }

        public virtual ICollection<Card> Cards { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
    }
}
