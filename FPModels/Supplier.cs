using System;
using System.Collections.Generic;

namespace LayeringEg.FPModels
{
    public partial class Supplier
    {
        public Supplier()
        {
            Products = new HashSet<Product>();
        }

        public int SupplierId { get; set; }
        public string? SuppName { get; set; }
        public string? Location { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
