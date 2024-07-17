namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Create a new instance of the Car class
            // Set values in the properties for the object
            // Print the values of each property to the Console
            var car = new Car();
            car.Make = "Honda";
            car.Model = "Accord";
            car.Year = 2022;
            
            Console.WriteLine($"Make of car: {car.Make}");
            Console.WriteLine($"Model of car: {car.Model}");
            Console.WriteLine($"Year of car: {car.Year}");
            
        }
    }
}
