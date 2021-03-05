using System;

namespace CodeBlog_25_AttributeAndReflecsion
{
    [AttributeUsage((AttributeTargets.Property) | (AttributeTargets.Constructor))]
    class GeoAttribute : Attribute
    {
        public int X { get; set; }

        public int Y { get; set; }

        public int Z { get; set; }

        public GeoAttribute()
        {

        }

        public GeoAttribute(int x, int y, int z)
        {
            //Проверка

            X = x;
            Y = y;
            Z = z;
        }

        public override string ToString()
        {
            return $"[{X},{Y},{Z}]"; 
        }
    }
}
