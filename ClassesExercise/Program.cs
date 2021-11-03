using System;

namespace ClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car() { Make = "Chevorlet", Model = "Tahoe", Age = 2016 };
            {
                Console.WriteLine($"I have a {myCar.Make}\n");

                Console.WriteLine($"The model of it is {myCar.Model}\n");

                Console.WriteLine($"It was made in {myCar.Age}\n");
            }
        }
    }
}
