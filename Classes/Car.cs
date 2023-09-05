using System;
namespace Classes
{
	public class Car
	{
        public Car()
        {

        }

		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }

        public Car(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }
    }
}

