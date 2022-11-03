namespace MySelf_Interfaces
{
    public class InvestmentFundVM : IInvestment
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Holdings { get; set; }

        public string Currency { get; set; }

        public bool Feed { get; set; }


        public InvestmentFundVM()
        {
        }

        public InvestmentFundVM(int id, string name, int holdings, bool feed)
        {
            Id = id;
            Name = name;
            Holdings = holdings;
            Currency = "EUR";
            Feed = feed;
        }
    }

}
