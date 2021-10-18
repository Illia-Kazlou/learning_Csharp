namespace Refactoring.Guru.Command
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код может параметризовать отправителя любыми
            // командами.
            // Сначала мы создаем экземпляр отправителя, который связан с командами
            Invoker invoker = new Invoker();
            invoker.SetOnStart(new SimpleCommand("Say Hi!"));

            invoker.SetOnFinish(new ComplexCommand(new Receiver(), "Send email", "Save report"));
            invoker.DoSomethingImportant();
        }
    }
}
