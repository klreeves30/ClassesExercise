using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesExercise
{
    class Car
    {
        public Car()
        {
        }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Age = 2016;
        }

       public string Make { get; set; }
       public string Model { get; set; }
        public int Age { get; set; }
        
        

    }
}
