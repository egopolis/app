namespace Epg.Resource
{
    public static class ResourceSamples
    {
        public static IResource Time = new ResourceEntity("Time");

        public static IResource Money = new ResourceEntity("Money");

        public static IResource MoneyEuro = new ResourceEntity
        {
            Id = "money-euro",
            Name = "Euro",
            Parent = Money
        };

        public static IResource MoneyDollar = new ResourceEntity
        {
            Id = "money-usd",
            Name = "US Dollar",
            Parent = Money
        };

        public static IResource MoneyRuble = new ResourceEntity
        {
            Id = "money-ruble",
            Name = "Ruble",
            Parent = Money
        };
    }
}
