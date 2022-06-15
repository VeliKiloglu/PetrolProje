using System;
using System.Collections.Generic;

#nullable disable

namespace PetrolProje.Models
{
    public partial class Brand
    {
        public Brand()
        {
            ConsLogs = new HashSet<ConsLog>();
            Models = new HashSet<Model>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }

        public virtual ICollection<ConsLog> ConsLogs { get; set; }
        public virtual ICollection<Model> Models { get; set; }
    }
}
