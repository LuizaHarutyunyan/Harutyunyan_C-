using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harutyunyan_C_
{
    internal class Task1
    {

        public void PrintHello()
        {
            Console.WriteLine("Enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 7)
            {
                Console.WriteLine("Hello");
            }
        }

        public void PrintName()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            if (name == "John")
            {
                Console.WriteLine("Hello, John");
            }
            else
            {
                Console.WriteLine("There is no such name");
            }
        }

        public void PrintMultipliesOfThree(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 3 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
            
            

        }
    }
}
