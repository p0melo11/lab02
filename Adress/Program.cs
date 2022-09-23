namespace lab02
{
    class Program
    {
        public static void Main(params string[] args)
        {
            Adress someAdress = new Adress();
            someAdress.Index = 916582;
            someAdress.City = "Kyiv";
            someAdress.Street = "Urlivska";
            someAdress.House = 221;
            someAdress.Apartment = 12;
            Console.WriteLine($"Index: {someAdress.Index}\nCity: {someAdress.City}\nStreet: {someAdress.Street}\nHouse: {someAdress.House}" +
                $"\nApartment: {someAdress.Apartment}");
        }
    }
    class Adress
    {
        private int _index;
        private string _city;
        private string _street;
        private int _house;
        private int _apartment;
        public int Index { get { return _index; } set { _index = value; } }
        public string City { get { return _city; } set { _city = value; } }
        public string Street { get { return _street; } set { _street = value; } }
        public int House { get { return _house; } set { _house = value; } }
        public int Apartment { get { return _apartment; } set { _apartment = value; } }
    }
}

