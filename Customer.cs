using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public int PhoneNumberId { get; set; }

        public PhoneNumber? PhoneNumber{ get; set; }
    }
}
