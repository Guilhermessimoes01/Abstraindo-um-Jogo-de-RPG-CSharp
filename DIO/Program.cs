using System;
using DIO.src.entities;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            knight arus = new knight("arus", 23, "knight");
            wizard wizard = new wizard("jenica", 23, "white wizard");

            Console.WriteLine(arus.attack());
            Console.WriteLine(wizard.attack(1));
        }
    }
}
