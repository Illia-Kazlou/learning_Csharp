using System;
using System.Collections.Generic;
using System.Text;

namespace CodeBlog_25_AttributeAndReflecsion
{
    //[GeoAttribute(10, 20, 30)]
    public class Photo
    {
        [GeoAttribute(10, 20, 30)]
        public string Name { get; set; }

        public string Path { get; set; }

        [GeoAttribute(10, 20, 30)]
        public Photo(string name)
        {
            // Проверка
            Name = name;

        }
    }
}
