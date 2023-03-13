using System;
using System.Collections.Generic;

namespace LayeringEg.FPModels
{
    public partial class Product
    {
        public int Pid { get; set; }
        public string? Pname { get; set; }
        public double? Price { get; set; }
        public int? Qty { get; set; }
        public DateTime? Doexp { get; set; }
        public int? Suppid { get; set; }

        public virtual Supplier? Supp { get; set; }
    }
}
