using System;

namespace CreateStruct
{
    struct Person
    {
        public string firstName;
        public string lastName;
        public int age;

        public Person(string _firstName, string _lastName, int _age)
        {
            firstName = _firstName;
            lastName = _lastName; 
            age = _age;
        }
        public override string ToString()
        {
            //Console.WriteLine("toString\n");
            return firstName + " " + lastName + ", age " + age;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Andrew", "Oleg", 35);
            Console.WriteLine(p); // ToString() is called by default
        }
    }
}