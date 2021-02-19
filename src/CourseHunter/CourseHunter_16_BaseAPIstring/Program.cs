using System;

namespace CourseHunter_16_BaseAPIstring
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = new string ("Abracadabra");

            //Метод начинается ли строка с ...
            bool startWhithAbr = name.StartsWith("Abra");
            Console.WriteLine(startWhithAbr);

            //Метод содержится ли в строке другая строка либо символю
            bool containsA = name.Contains("Abr");
            Console.WriteLine(containsA);

            //Метод заканчивается ли строка на ...
            bool endWhithBra = name.EndsWith("bra");
            Console.WriteLine(endWhithBra);

            //Метод находит первое вхождение заданной подстроки или символа в строке. 
            //Если искомый символ или подстрока не обнаружены, то возвращается значение -1(строковым массиве).
            int indexFirstA = name.IndexOf("a", 1);
            Console.WriteLine(indexFirstA);

            //Метод находит крайнее вхождение заданной подстроки или символа в строке.
            int indexLastA = name.LastIndexOf('a');
            Console.WriteLine(indexLastA);

            //Свойство вычисляет количество символов в строкею.
            int lengthString = name.Length;
            Console.WriteLine(lengthString);

            //Метод Получение подстроки из строкию.
            string substringFrom = name.Substring(5);
            string substringFromTo = name.Substring(2, 6);
            Console.WriteLine(substringFrom);
            Console.WriteLine(substringFromTo);

            string empty = new string ("");
            string whiteSpase = new string (" ");

            //Метод определения пустой строки.
            Console.WriteLine();
            Console.WriteLine("IsNullOrEmpty");
            bool isNullOrEmpty = string.IsNullOrEmpty(empty);
            Console.WriteLine(isNullOrEmpty);

            //Метод определения пустой или строки с пробелом
            Console.WriteLine();
            Console.WriteLine("WhiteSpase");
            bool whitespase = string.IsNullOrWhiteSpace(whiteSpase);
            Console.WriteLine(whiteSpase);

            string str = string.Empty; //свойство строки, тоже самое что и string empty = new string ("");

            //Метод объединения строк, так как есть.
            string nameConcat = string.Concat("My ", "name ", "is ", "Tom");
            Console.WriteLine(nameConcat);

            //Метод объединения строк, так как есть, только в начале указывается разделителью
            nameConcat = string.Join(",", "My", "Name", "is");
            Console.WriteLine(nameConcat);

            //Метод вставки строки в строку.
            nameConcat = nameConcat.Insert(0, "By the way");
            Console.WriteLine(nameConcat);

            //Метод удаления строки.
            nameConcat = nameConcat.Remove(0, 10);
            Console.WriteLine(nameConcat);

            //Метод замены однорго символа в строке на другогою
            nameConcat = nameConcat.Replace("y", "&");
            Console.WriteLine(nameConcat);

            //Метод разделения данных.
            string inputData = new string("12;23;354;56;687;13;");
            string[] splitData = inputData.Split(";");
            string first = splitData[0];
            Console.WriteLine(first);

            //Метод перегона строки в массив символов.
            char[] chars = inputData.ToCharArray();
            Console.WriteLine(chars[5]);
            Console.WriteLine(inputData[5]);

            //Метьод перегона в нижний и верхний регистр.
            string lower = nameConcat.ToLower();
            Console.WriteLine(lower);
            string upper = nameConcat.ToUpper();
            Console.WriteLine(upper);

            //Метод обрезки пробелов слева и справа, можно похожим методом только справа или слеваю.
            string ojhn = new string(" John ");
            Console.WriteLine(ojhn.Trim());
        }
    }
}
