using System;

namespace ClassesandObject_Video
{
    class Program
    {
        static void Main(string[] args)
        {
            Person somePerson = new Person();
            somePerson.Name = "Kate Murphy";
            somePerson.Age = 21;

            Person anotherPerson = new Person();
            anotherPerson.Name = "Kyler Moore";
            anotherPerson.Age = 25;

            Person oldestPerson = somePerson;

            anotherPerson = null;
            somePerson = null;
            oldestPerson = null; 
        }
    }
}
