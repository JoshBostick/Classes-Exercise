namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
           var car = new Car();
            car.Year = 2002;
            car.Make = "Toyota";
            car.Model = "4Runner";

            Console.WriteLine($"My car is a {car.Year} {car.Make} {car.Model}.");
           
        }
    }
}
