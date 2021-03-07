using System;
using System.Text;

namespace CodeBlog_26_Serialize
{
    [Serializable]
    public class Group
    {
        [NonSerialized]
        private readonly Random random = new Random(DateTime.Now.Millisecond);

        public Group()
        {
            Number = random.Next(1, 10);
            Name = "Group " + random; 
        }

        public Group(int number, string name)
        {
            // Check input data
            Number = number;
            Name = name;
        }

        public int Number { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(Name);
            stringBuilder.Append(Number);

            return stringBuilder.ToString();
        }
    }
}
