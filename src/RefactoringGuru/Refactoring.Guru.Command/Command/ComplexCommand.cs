using System;

namespace Refactoring.Guru.Command
{
    // Но есть и команды, которые делегируют более сложные операции другим
    // объектам, называемым «получателями».
    public class ComplexCommand : ICommand
    {
        private Receiver _receiver;

        // Данные о контексте, необходимые для запуска методов получателя.
        private string _a;
        private string _b;


        public ComplexCommand(Receiver receiver, string a, string b)
        // Команда - это поведенчиский патерн, который первращает запросы в объекты,
        //позволяя их передавать в качестве аргументов
        {
            this._receiver = receiver;
            this._a = a;
            this._b = b;
        }

        public void Execute()
        {
            Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
            this._receiver.DoSomething(this._a);
            this._receiver.DoSomethingElse(this._b);
        }
    }
}