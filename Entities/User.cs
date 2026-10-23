using AgendaApi.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaApi.Entities
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; } = String.Empty;
        public string Surname { get; set; } = String.Empty;
        [Required]
        [EmailAddress]
        public string Email { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

        public ICollection<Contact> Contacts { get; set; }
        public State State { get; set; } = State.Active;
    }
}
