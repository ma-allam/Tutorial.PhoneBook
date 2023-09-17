using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.PhoneBook.Domain.Entities
{
    public class PhoneNumber
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Number { get; set; }
        public Guid? PhoneNumberTypeId { get; set; }
        [ForeignKey("PhoneNumberTypeId")]
        public virtual PhoneNumberType PhoneNumberType { get; set; }
        public Guid? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
    }
}
