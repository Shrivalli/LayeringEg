using System;
using System.Collections.Generic;

namespace LayeringEg.FPModels
{
    public partial class Customer
    {
        public int Cid { get; set; }
        public string? CustName { get; set; }
        public string Email { get; set; } = null!;
        public string Pwd { get; set; } = null!;
    }
}
