using System.ComponentModel.DataAnnotations;

namespace Tutorial.PhoneBook.Domain.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string RealName { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Salt { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public virtual List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
    }
}