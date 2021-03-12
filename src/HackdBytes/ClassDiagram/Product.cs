using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Category ProductCategory { get; set; }
    }
}
