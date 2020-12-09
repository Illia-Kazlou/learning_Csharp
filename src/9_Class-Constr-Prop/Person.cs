using System;


namespace _9_Class_Constr_Prop
{
    public class Person
    {
        private string _name;

        public string SecondName { get; set; }

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Имя не может быть пустым");
                }
                _name = value + "+Maick";
            }
        }

        public string FullName
        {
            get
            {
                return SecondName + " " + Name;
            }
        }

        public string ShortName
        {
            get
            {
                return $"{SecondName} {Name.Substring(0, 1)}.";
            }
        }

        ///тоже что и вверху

        //public string GetName()
        //{
        //    return _name;
        //}

        //public void SetName(string name)
        //{
        //    if (string.IsNullOrWhiteSpace(name))
        //    {
        //        throw new ArgumentNullException("Имя не может быть пустым");
        //    }
        //    _name = name;
        //}


    }
}
