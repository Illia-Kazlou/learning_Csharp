using System;
using System.Collections.Generic;

namespace MySelf_Generic
{
    public class Program
                           
    {
        static void Main(string[] args)
        {
            var isUS = true;
            var invetSecurity = new InvestmentViewModel<InvestmentSecurityVM>();
            var invetFunds = new InvestmentViewModel<InvestmentFundVM>();

            if (isUS)
            {
                invetSecurity = new InvestmentViewModel<InvestmentSecurityVM>(1, new List<InvestmentSecurityVM>()
                {
                    new InvestmentSecurityVM( 1, "SecurityName 1", 10, "AssetClass 1"),
                    new InvestmentSecurityVM(2, "SecurityName 2", 12, "AssetClass 2" ),
                    new InvestmentSecurityVM(3, "SecurityName 3", 13, "AssetClass 2" )
                });
            }

            foreach (var item in invetSecurity.Investments)
            {
                Console.WriteLine($"{item.Name}, {item.Currency}");
            }

            isUS = false;
            if (!isUS)
            {
                invetFunds = new InvestmentViewModel<InvestmentFundVM>(1, new List<InvestmentFundVM>()
                {
                    new InvestmentFundVM( 1, "SecurityName 1", 10, true ),
                    new InvestmentFundVM(2, "SecurityName 2", 12, false ),
                    new InvestmentFundVM(3, "SecurityName 3", 13, true )
                });
            }

            foreach (var item in invetFunds.Investments)
            {
                Console.WriteLine($"{item.Name}, {item.Currency}");
            }

            Console.ReadLine();
        }
    }
}
