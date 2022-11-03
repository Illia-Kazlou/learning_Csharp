namespace MySelf_Generic
{
    public class InvestmentFundVM : BaseInvestmentFund
    {
        public bool Feed { get; set; }

        public InvestmentFundVM(int id, string name, int holdings, bool feed) : base(id, name, holdings)
        {
            Currency = "EUR";
            Feed = feed;
        }

        public InvestmentFundVM()
        {
        }
    }

}
