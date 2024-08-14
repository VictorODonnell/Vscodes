using System;

namespace Polymorphism 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();

            Car[] vechicles = {car, boat, bicycle};


            Console.ReadKey();
        }
    }
    class Vechicle 
    {

    }
    class Car: Vechicle
    {

    }
    class Bicycle: Vechicle
    {
        
    }
    class Boat: Vechicle
    {
        
    }
}