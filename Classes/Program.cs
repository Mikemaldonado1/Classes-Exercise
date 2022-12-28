namespace Classes
{
    public class Program
    {

        static void Main(string[] args)
        {
            Car car1 = new Car();   //Instance

            car1.Make = "GMC";
            car1.Model = "1500";
            car1.Year = 2014;

            Console.WriteLine(car1.Make);
            Console.WriteLine(car1.Model);
            Console.WriteLine(car1.Year);
        }
    
    }
}
