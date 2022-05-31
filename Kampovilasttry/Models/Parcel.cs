using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampovilasttry.Models
{
    public class Parcel : Object
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int Capacity { get; set; }
        public string Season { get; set; }
        public int Price { get; set; }

    }
}
