using System;
namespace practise.Core
{
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }


        public void GetFullInfo()
        {
            Console.WriteLine($"{Name} { Price}");
        }
    }
}

