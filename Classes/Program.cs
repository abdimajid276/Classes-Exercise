namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var carOne = new Car();
            carOne.Make = "Honda";
            carOne.Model = "Accord";
            carOne.year = 2021;
            
           Console.WriteLine($"This is a {carOne.Make} {carOne.Model}, made in the year{carOne.year}.");
        }
    }
}
