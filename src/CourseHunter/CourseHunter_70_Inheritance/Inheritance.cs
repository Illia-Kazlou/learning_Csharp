using System;

namespace CourseHunter_70_Inheritance
{
    public class BankTerminal //наследуемый класс
    {
        protected string id;

        public BankTerminal(string id)
        {
            this.id = id;
        }

        public virtual void Connect()
        {
            Console.WriteLine($"General Connectig Protocol...{id}");
        }
    }

    public class ModelXTermonal : BankTerminal // класс наследник 
    {
        public ModelXTermonal(string id) : base(id)
        //чтобы это не прописывать в каждом наследнике можно этот конструктор
        //реализовать в наследуемом классе 
        {
            //base.id = id;
        }

        public override void Connect() // и метод который переопредиляет реализацию наследуемого класса
        {
            // и здесь у нас есть доступ к ID
            base.Connect();
            Console.WriteLine("Aditional action for Model X");
        }
    }

    public class ModelYTermonal : BankTerminal // класс наследник 
    {
        public ModelYTermonal(string id) : base(id)
        {
        }

        public override void Connect() // и метод который переопредиляет реализацию наследуемого класса
        {
            Console.WriteLine("Action for model Y");
        }
    }

}
