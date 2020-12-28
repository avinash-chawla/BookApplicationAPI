using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookApplicationAPI.Models
{
    public class Book
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Type { get; set; }
    }
}
