using System.Collections.Generic;

namespace MySelf_Generic
{
    public class InvestmentViewModel<T>
    {
        public InvestmentViewModel()
        {
        }

        public InvestmentViewModel(int id, List<T> investments)
        {
            Id = id;
            Investments = investments;
        }

        public int Id { get; set; }

        public List<T> Investments { get; set; }
    }
}
