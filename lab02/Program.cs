namespace lab02
{
    class Program
    {
        public static void Main(params string[] args)
        {
            Conventer someConventer = new Conventer(37, 38, 0.5);
            Console.WriteLine(someConventer.UahToUsd(64));
            Console.WriteLine(someConventer.UahToEur(64));
            Console.WriteLine(someConventer.UahToRub(64));
            Console.WriteLine(someConventer.UsdToUah(64));
            Console.WriteLine(someConventer.EurToUah(64));
            Console.WriteLine(someConventer.RubToUah(64));

        }
    }
    class Conventer
    {
        private double _usd;
        private double _eur;
        private double _rub;
        public Conventer(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }
        public double UahToUsd(double uah) { return uah / _usd; }
        public double UahToEur(double uah) { return uah / _eur; }
        public double UahToRub(double uah) { return uah / _rub; }
        public double UsdToUah(double uah) { return _usd * uah; }
        public double EurToUah(double uah) { return _eur * uah; }
        public double RubToUah(double uah) { return _rub * uah; }



    }
}
