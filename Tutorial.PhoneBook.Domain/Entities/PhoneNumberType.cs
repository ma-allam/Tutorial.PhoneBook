using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial.PhoneBook.Domain.Entities
{
    public class PhoneNumberType
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Title { get; set; }
        public virtual List<PhoneNumber> PhoneNumbers { get; set; } = new List<PhoneNumber>();
    }
}
