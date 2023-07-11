namespace ReflectionPracticeProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NearestNumber nearestNumber = new NearestNumber();
            Console.WriteLine("Reflection Practice Problem!");
            Console.WriteLine("Enter any number");
            int N = int.Parse(Console.ReadLine());
            int result = nearestNumber.FindClosestNumberWithEvenDigitsPositive(N);
            Console.WriteLine(result);
        }
    }
}