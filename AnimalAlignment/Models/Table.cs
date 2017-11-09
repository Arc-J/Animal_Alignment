using System;
using System.Collections.Generic;

namespace AnimalAlignment.Models
{
    public partial class Table
    {
        public int Id { get; set; }
        public byte[] Image { get; set; }
        public string Name { get; set; }
    }
}
