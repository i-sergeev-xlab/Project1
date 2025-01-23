using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        class House
        {
            public string street;
            public int number;

            public void Print()
            { 
                Console.WriteLine($"{street}, {number}");
            }       
        }
        static void Main(string[] args)
        {
            House Tower = new House();
            Tower.street = "Красная";
            Tower.number = 50;

            Tower.Print();
        }

    }
}
