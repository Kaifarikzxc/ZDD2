using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЗДд2
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> person1 = new List<Person>()
          {
              new Person("ДИма",14),
              new Person("Саша", 15),
              new Person ("Коля", 25)

          };
            person1.Sort();

            foreach (Person person in person1) 
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }
        
            
    }
}
