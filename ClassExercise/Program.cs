using System;

namespace ClassExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Tesla";
            car1.Model = "y";
            car1.Year = 2019;

            Console.WriteLine($"Car Make: {car1.Make}\nCar Model: {car1.Model}\nCarYear: {car1.Year}") ; 

        }
    }
}