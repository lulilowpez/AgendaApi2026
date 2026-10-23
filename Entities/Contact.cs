using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaApi.Entities
{
    public class Contact
    {
      [Key]
      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string ?ImageUrl { get; set; }
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Surname { get; set; } = String.Empty;
        public int Phone { get; set; }
        public string ?Email { get; set; }
        public string ?Adress { get; set; }
        public string? Description { get; set; }
        [ForeignKey("UserId")]
        public User? User { get; set; }
        public int UserId { get; set; }
        public bool IsFavorite { get; set; } = false;

    }
}
