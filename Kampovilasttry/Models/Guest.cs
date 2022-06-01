using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampovilasttry.Models
{
    public class Guest : Person
    {
        public int GuestId { get; set; }
        public string OIB { get; set; }
        public string Phone { get; set; }
        public int Age { get; set; }

    }


}
