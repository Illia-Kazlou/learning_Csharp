namespace MySelf_Generic
{
    public abstract class BaseInvestmentFund
    {
        public BaseInvestmentFund(int id, string name, int holdings)
        {
            Id = id;
            Name = name;
            Holdings = holdings;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public int Holdings { get; set; }

        public string Currency { get; set; }
    }

}
