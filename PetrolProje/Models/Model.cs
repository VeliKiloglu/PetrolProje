using System;
using System.Collections.Generic;

#nullable disable

namespace PetrolProje.Models
{
    public partial class Model
    {
        public int MakeId { get; set; }
        public string ModelName { get; set; }
        public int ModelYear { get; set; }
        public int? BrandId { get; set; }

        public virtual Brand Brand { get; set; }
    }
}
