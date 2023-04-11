namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 17;
            var b = 4;
            var sum = a + b;
            var sum2 = a - b;
            var quotient = a / b;
            var remainder = a % b;
            if (a == 17 && b == 4) ;
            Console.WriteLine($"{a}+{b}={sum}");
            Console.WriteLine($"{a}-{b}={sum2}");
            Console.WriteLine($"{a}/{b}={quotient}");
            Console.WriteLine($"The remainder of {a}/{b} is {remainder}");
            Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            Console.WriteLine(Class1.AreaOfCircle(radius));
        }
        public static double AreaOfCircle(double radius)
        {
            var area = Math.PI * radius * radius;
            return area;
        }
    }
}
