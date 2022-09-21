namespace TestSystem.Core.DTOs
{
    public class ProfitDTO
    {
        public ProfitDTO()
        {
            Periods = new List<Period>();
        }

        public string Name { get; set; }
        public float FixedCost { get; set; }
        public float Total { get; set; }
        public List<Period> Periods { get; set; }
    }

    public class Period
    {
        public string Description { get; set; }
        public float Profit { get; set; }
        public float Commission { get; set; }
        public float Loot { get; set; }

    }
}
