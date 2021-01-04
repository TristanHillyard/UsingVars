using System;

namespace UsingVars
{
    class Program
    {
        public class Employee
        {
            private int id;
            private string name;

            public Employee(string Name, int id)
            {
                this.name = Name;
                this.id = id;
            }
        }
        
        static void Main(string[] args)
        {
            const string openingLine = "Hello, World";
            Console.WriteLine(openingLine);
            var secondLine = "With all of COVID-19 flying around everyone is staying inside.";
            Console.WriteLine(secondLine);

            Employee Joe = new Employee("Joe", 12);
            Employee Tim = new Employee("Tim", 13);
        }
    }
}
