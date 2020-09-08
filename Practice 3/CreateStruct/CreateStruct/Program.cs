using System;
using System.Collections.Generic;
using System.Text;

namespace CreateStruct {
    class Program {
        static void Main(string[] args) {
            Manager p = new Manager("Михал", "Палыч", 32, Person.Genders.Male, "22505", "ул. Красноармейская 4");
            Console.WriteLine(p.ToString());
            Console.ReadKey(); // prevents from closing
        }

        class Person {
            public string firstName;
            public string lastName;
            public int age;
            public Genders gender;

            public Person(string _firstName, string _lastName, int _age, Genders _gender) {
                firstName = _firstName;
                lastName = _lastName;
                age = _age;
                gender = _gender;
            }

            public override string ToString() {
                return firstName + " " + lastName + " (" + gender + "), age: " + age;
            }

            public enum Genders : int { Male, Female };
        }
        class Manager : Person {
            public string phoneNumber;
            public string officeLocation;

            public Manager(string _firstName, string _lastName, int _age, Genders _gender, string _phoneNumber,
                string _officeLocation) : base(_firstName, _lastName, _age, _gender) {
                phoneNumber = _phoneNumber;
                officeLocation = _officeLocation;
            }

            public override string ToString() {
                return base.ToString() + ", phone: " + phoneNumber + ", location: " + officeLocation;
            }
        }
    }
}
