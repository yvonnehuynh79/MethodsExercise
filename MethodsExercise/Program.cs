namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {

            Methods.Add(5, 5);
            Methods.Subtract(10, 2);
            Methods.Multiply(2, 7);
            Methods.Divide(7, 2);

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine("What is your favorite TV show?");
            string TvShow = Console.ReadLine();

            Console.WriteLine($"Hi, my name is {name}, I like all the colors,\n +" +
                $" but if I have to pick one as a favorite color it would be {color}.\n+" +
                $"My favorite animal is {animal}.  And my favorite TV show of all times is{TvShow}.");




       

        }
    }
}
