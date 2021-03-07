using System;
using System.Runtime.Serialization;
using System.Text;

namespace CodeBlog_26_Serialize
{
    [Serializable]
    [DataContract] 
    public class Student
    {

        public Student()
        {
            Name = this.Name;
            Age = this.Age;
            Group = this.Group;
        }

        public Student(string name, int age)
        {
            // check input data
            Name = name;
            Age = age;
            Group = this.Group;
        }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public Group Group { get; set; }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Name}, {Age} y.o., {Group}");

            return stringBuilder.ToString();
        }
    }
}
