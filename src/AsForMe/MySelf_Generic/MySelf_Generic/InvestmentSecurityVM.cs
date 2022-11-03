namespace MySelf_Generic
{
    public class InvestmentSecurityVM : BaseInvestmentFund
    {
        public string AssetClass { get; set; }
        public InvestmentSecurityVM(int id, string name, int holdings, string assetClass) : base(id, name, holdings)
        {
            Currency = "USD";
            AssetClass = assetClass;
        }

        public InvestmentSecurityVM()
        {
        }
    }
}
