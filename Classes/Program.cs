namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create instance of the Car class
            
            Car carOne = new Car();
            carOne.Make = "Ford";
            carOne.Model = "Fiesta";
            carOne.Year = 2000;
            
            //Print the values of each property to the Console
            
            Console.WriteLine($"Make: {carOne.Make}, Model: {carOne.Model}, Year: {carOne.Year}");
        }
    }
}
