namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var chevy = new Car();
            var ford = new Car();

            chevy.Make = "chevy";
            chevy.Model = "Bolt";
            chevy.Year = 2022;

            ford.Make = "Ford";
            ford.Model = "Mustang";
            ford.Year = 2022;

            Console.WriteLine("Make  Model   Year");
            Console.WriteLine("------------------");

            var cars = new List<Car>();
            cars.Add(chevy);
            cars.Add(ford);

            foreach(var car in cars)
            {
                Console.WriteLine($"{car.Make} {car.Model} {car.Year}");
            }
            




        }
    }
}
