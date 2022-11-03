using System;
using System.Collections.Generic;
using System.Linq;

namespace MySelf_Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("If type Type 1 - is US");

            var type = Console.ReadLine().ToString().Contains('1');

            var investmentViewModel = new InvestmentViewModel(type, 1, "Investment", 15, true, "AssetClass");
            Console.WriteLine($"{investmentViewModel.Investment.Name}, {investmentViewModel.Investment.Currency}");

             Console.ReadLine();
        }
    }
}
