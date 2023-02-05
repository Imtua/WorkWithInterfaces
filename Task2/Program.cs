namespace Task2
{
    public class Program
    {
        static ILogger logger { get; set; }
        static void Main(string[] args)
        {
            logger = new Logger();

            MyMath myMath = new MyMath(logger);
            int a, b;

            while (true)
            {
                Console.WriteLine("Введите два числа для сложения: ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    myMath.Addition(a, b);
                }
                catch (Exception ex)
                {
                    myMath.Logger.Error(ex);
                }
            }
        }
    }
}