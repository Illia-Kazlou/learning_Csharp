using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDataBaseFirst
{
    public partial class Customer
    {
        public Customer()
        {
            Orders = new HashSet<Order>();
        }

        public int Id { get; set; }
        public int ManagerId { get; set; }
        public string Name1 { get; set; }

        public virtual Manager Manager { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
