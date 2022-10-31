using System.Xml.Schema;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var Tesla = new Car();
            Tesla.Make = "Tesla";
            Tesla.Model = "3";
            Tesla.Year = 2022;
            Console.WriteLine($"I crashed a {Tesla.Make} Model {Tesla.Model} {Tesla.Year}. :(");
        }
    }
}
