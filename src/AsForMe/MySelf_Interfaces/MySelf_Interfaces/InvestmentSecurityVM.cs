namespace MySelf_Interfaces
{
    public class InvestmentSecurityVM : IInvestment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Holdings { get; set; }

        public string Currency { get; set; }

        public string AssetClass { get; set; }

        public InvestmentSecurityVM()
        {
        }

        public InvestmentSecurityVM(int id, string name, int holdings, string assetClass)
        {
            Id = id;
            Name = name;
            Holdings = holdings;
            Currency = "USD";

            AssetClass = assetClass;
        }
    }
}
