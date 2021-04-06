using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDataBaseFirst
{
    public partial class Order
    {
        public int Id { get; set; }
        public int Amount1 { get; set; }
        public DateTime Date1 { get; set; }
        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
