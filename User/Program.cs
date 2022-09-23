namespace lab02
{
    class Program
    {
        public static void Main()
        {
            User someUser = new User("myLogin", "Alex", "Terentiv", 19);
            Console.WriteLine($"{someUser.Login}: {someUser.Firstname} {someUser.Lastname}\nAge: {someUser.Age}\n{someUser.CreationDate}");
            Console.ReadLine();
        }
    }
    public class User
    {
        private string _login;
        private string _firstname;
        private string _lastname;
        private int _age;
        private readonly DateTime _creationDate;

        public string Login { get { return _login; } set { _login = value; } }
        public string Firstname { get { return _firstname; } set { _firstname = value; } }
        public string Lastname { get { return _lastname; } set { _lastname = value; } }
        public int Age { get { return _age; } set { _age = value; } }
        public DateTime CreationDate { get { return _creationDate; } }

        public User(string login, string firstname, string lastname, int age)
        {
            _login = login;
            _firstname = firstname;
            _lastname = lastname;
            _age = age;
            _creationDate = DateTime.Now;
        }

    }

}
