using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.getPersonData();
            Console.WriteLine("O nome da pessoa é {0} e a sua idade é {1}", p1.name, p1.age);
            Person p2 = new Person();
            p2.getPersonData();
            Console.WriteLine("O nome da pessoa é {0} e a sua idade é {1}", p2.name, p2.age);
            string older_person = p2.age > p1.age ? p2.name : p1.name;
            Console.WriteLine("O nome da pessoa mais velha é {0}", older_person);
            
        }
    }
}