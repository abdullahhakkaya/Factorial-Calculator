internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a positive number to calculate its factorial : ");
        ulong number = Convert.ToUInt64(Console.ReadLine());
        ulong sum = 1;

        if (number > 0)
        {
            for (ulong i = number; i > 0; i--)
            {
                sum *= i;
            }
            Console.WriteLine("Calculation result : " + sum);
        }
        else
        {
            Console.WriteLine("You have entered an invalid input.");
        }
        Console.ReadLine();
    }
}