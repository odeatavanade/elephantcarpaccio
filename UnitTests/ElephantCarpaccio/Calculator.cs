namespace ElephantCarpaccio
{
    public class Calculator
    {
        static readonly Dictionary<string, decimal> taxes = new Dictionary<string, decimal>{
            {"ut", 1.0685M},
            {"nv", 1.080M},
            {"tx", 1.0625M},
            {"al", 1.04M},
            {"ca", 1.0825M},
        };

        public static decimal GetPrice(int quantity, decimal price, string state)
        {
            var sum = quantity * price;
            var taxe = taxes[state];
            return Math.Round(sum * taxe, 2);
        }
    }
}
