namespace MySelf_Interfaces
{
    public class InvestmentViewModel
    {
        public int Id { get; set; }

        public IInvestment Investment { get; set; }

        public InvestmentViewModel(bool iSUS, int id, string name, int holding, bool isFeed, string assetClass)
        {
            if (iSUS)
            {
                Investment = new InvestmentSecurityVM(id, name, holding, assetClass);
            }
            else
            {
                Investment = new InvestmentFundVM(id, name, holding, isFeed);
            }
        }

        public InvestmentViewModel(bool iSUS)
        {
            if (iSUS)
            {
                Investment = new InvestmentSecurityVM();
            }
            else
            {
                Investment = new InvestmentFundVM();
            }
        }
    }

    public interface IInvestment
    {
        int Id { get; set; }

        public string Name { get; set; }

        public int Holdings { get; set; }

        public string Currency { get; set; }
    }
}
