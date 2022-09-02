using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class PhoneNumber
    {
        public int Id { get; set; }

        public String Number { get; set; } = null!;

        public Customer? Customer { get; set; }

    }
}
