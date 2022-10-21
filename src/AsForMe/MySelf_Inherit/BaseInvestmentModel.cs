namespace MySelf_Inherit
{
    public abstract class BaseInvestmentModel<T>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Holdings { get; set; }

        public string Currency { get; set; }


    }
}
