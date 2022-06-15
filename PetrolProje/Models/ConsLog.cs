using System;
using System.Collections.Generic;

#nullable disable

namespace PetrolProje.Models
{
    public partial class ConsLog
    {
        public int LogId { get; set; }
        public double Consumption { get; set; }
        public int? BrandId { get; set; }
        public string UserId { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
