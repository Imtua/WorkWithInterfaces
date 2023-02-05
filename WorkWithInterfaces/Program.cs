namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
			MyMath myMath = new MyMath();
            int a,b,result;
            while (true)
            {
                Console.WriteLine("Введите два числа для сложения: ");
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    b = Convert.ToInt32(Console.ReadLine());

                    result = myMath.Addition(a, b);
                    Console.WriteLine($"Результат: {result}");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Ошибка: {e.Message}");
                    Console.WriteLine(e.GetType().ToString());
                }
            }
        }
    }
}