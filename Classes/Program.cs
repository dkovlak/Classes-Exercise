namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();

            car1.Make = "BMW";
            car1.Model = "M3";
            car1.Year = 2023;

            Car car2 = new Car("Nissan", "GTR", 2017);

            Car car3 = new Car
            {
                Make = "Mercedes",
                Model = "220",
                Year = 2022
            };

            var carList = new List<Car>() { car1, car2, car3 };

            foreach (var each in carList)
            {
                if (each == car1) { Console.WriteLine($"First car: {each.Make} {each.Model} {each.Year}"); }
                if (each == car2) { Console.WriteLine($"Second car: {each.Make} {each.Model} {each.Year}"); }
                if (each == car3) { Console.WriteLine($"Third car: {each.Make} {each.Model} {each.Year}"); }
            }

        }
    }
}
