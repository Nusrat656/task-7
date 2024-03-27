namespace ConsoleApp10
{
    internal class User
    {
        public string Name;
        public string Parol;

        public string UserName
        {
            get { return Name; }
            set
            {
                if (value != null && value.Length >= 8)
                {
                    Name = value;
                }
                else
                {
                    Console.WriteLine("Ad sertlere uygun deyil");
                }
            }
        }
        public string GetPassword
        {
        get { return Parol; }
        set
        {
                if (value !=null && value.Length >= 8 && ContainsUppercase(value) && ContainsLowercase(value) && ContainsDigit(value))
                {
                    Parol = value;
                }
                else
                {
                    Console.WriteLine("Parol sertlere uygun deyil");
                }
            }
        }
        public User(string userName, string password)
        {
            Name = userName;
            Parol = password;
        }

        public User()
        {
        }

        public bool ContainsUppercase(string str)
        {
            foreach (char n in str)
            {
                if (char.IsUpper(n))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsLowercase(string str)
        {
            foreach (char n in str)
            {
                if (char.IsLower(n))
                {
                    return true;
                }
            }
            return false;
        }

        public bool ContainsDigit(string str)
        {
            foreach (char n in str)
            {
                if (char.IsDigit(n))
                {
                    return true;
                }
            }
            return false;
        }

        internal static void Username()
        {
            throw new NotImplementedException();
        }

        internal static void Password()
        {
            throw new NotImplementedException();
        }
    }   
   

}
