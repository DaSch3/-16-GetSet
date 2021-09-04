using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSet
{
    class Program
    {
        static void Main(string[] args)
        {
            Person peter = new Person();

            peter.Alter = 10;
            Console.WriteLine(peter.Alter);

            Console.ReadKey();
        }
    }

    class Person
    {
        //Private Variablen
        private int alter;

        //Eigenschaften
        public int Alter
        {
            get
            {
                Console.WriteLine("Alter wurde gelesen");
                return alter;
            }
            set
            {
                Console.WriteLine("Alter wurde überschrieben");
                alter = value;
            }
        }
    }
}
