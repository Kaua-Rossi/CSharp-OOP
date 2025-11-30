namespace Exercise06Section04
{
    internal static class CoinConverter
    {
        const double IOF = 0.06;
        public static double DollarToReal(double dollarAmount, double exchangeRate)
        {
            return (dollarAmount * exchangeRate) * (1 + IOF);
        }
    }
}
