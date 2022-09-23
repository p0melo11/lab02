namespace lab02
{
    class Program
    {
        public static void Main(params string[] args)
        {
            Employee someEmployee = new Employee("Tayler", "Korkishko", Position.Junior, 6.5);
            Console.WriteLine($"Firstname: {someEmployee.firstname}");
            Console.WriteLine($"Lastname: {someEmployee.lastname}");
            Console.WriteLine($"Position: {someEmployee.position}");
            Console.WriteLine($"Experience: {someEmployee.experience}");
            Console.WriteLine($"Salary: {someEmployee.Salary()}");
            Console.WriteLine($"Tax: {someEmployee.Tax()}");
        }
    }
    class Employee
    {
        private string _firstname;
        private string _lastname;
        private Position _position;
        private double _experience;
        public Employee(string firstname, string lastname, Position position, double experience)
        {
            _firstname = firstname;
            _lastname = lastname;
            _position = position;
            _experience = experience;
        }
        public string firstname { get { return _firstname; }  }
        public string lastname { get { return _lastname; }  }
        public Position position { get { return _position; } }
        public double experience { get { return _experience; } }
        public double Salary()
        {
            return (int)_position * 6500 * (_experience / 2);
        }
        public double Tax()
        {
            return Salary() * 0.1;
        }
    }
    public enum Position
    {
        Trainee = 1,
        Junior,
        Middle,
        Senior
    }
}
