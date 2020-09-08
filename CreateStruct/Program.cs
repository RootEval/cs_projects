using System;

namespace CreateStruct
{
    
    struct Person
    {
        public enum Genders : int { Female, Male };
        public string firstName;
        public string lastName;
        public int age;
        public Genders gender;

        public Person(string _firstName, string _lastName, int _age, Genders _gender)
        {
            firstName = _firstName;
            lastName = _lastName; 
            age = _age;
            gender = _gender;
        }
        public override string ToString()
        {
            //Console.WriteLine("toString\n");
            // v1: return firstName + " " + lastName + ", age " + age;
            return firstName + " " + lastName + " (" + gender + "), age " + age;
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("Andrew", "Oleg", 35, Person.Genders.Male);
            Console.WriteLine(p); // ToString() is called by default
        }
    }
}