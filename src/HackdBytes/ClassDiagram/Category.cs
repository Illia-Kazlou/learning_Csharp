﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassDiagram
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}