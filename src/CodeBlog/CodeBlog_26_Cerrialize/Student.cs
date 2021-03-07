using System;
using System.Text;

namespace CodeBlog_26_Serialize
{
    [Serializable]
    public class Student
    {
        public Student(string name, int age)
        {
            // check input data
            Name = name;
            Age = age;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public Group Group { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Name}, {Age} y.o., {Group}");

            return stringBuilder.ToString();
        }
    }
}
