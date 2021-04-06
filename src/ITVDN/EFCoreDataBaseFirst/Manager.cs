using System;
using System.Collections.Generic;

#nullable disable

namespace EFCoreDataBaseFirst
{
    public partial class Manager
    {
        public Manager()
        {
            Customers = new HashSet<Customer>();
        }

        public int Id { get; set; }
        public string Name1 { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
