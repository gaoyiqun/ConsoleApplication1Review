using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lecture2Example
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animalList = new List<Animal>();

            animalList.Add(new Duck());
            animalList.Add(new Donkey());

            foreach (Animal animal in animalList)
            {
                animal.Walk();
            }

            Console.ReadLine();
        }
    }
}
