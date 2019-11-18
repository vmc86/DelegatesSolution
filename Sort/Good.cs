using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Good
    {
        public int id { get; set; }
        public string title { get; set; }
        public decimal price { get; set; }

        public override string ToString()
        {
            return $"{id} {title} {price}";
        }
    }
}
