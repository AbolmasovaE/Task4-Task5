using NLog;
using System;

namespace Calculator
{

    public class Program
    {
        private static Logger log = LogManager.GetCurrentClassLogger();

        public static void Main(string[] args)
        {
            log.Debug("Мной найден дебаг!");
            while (true)
            {
                double a, b;
                char z;
                try

                {

                    Console.WriteLine("Введите первое число ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите второе число ");
                    b = Convert.ToDouble(Console.ReadLine());

                }
                catch (Exception)
                {
                    log.Info("Мной найден дебаг!");
                    Console.WriteLine("Ошибка!Введите число, а не символ!");
                    Console.ReadLine();
                    continue;
                }
                log.Debug("Мной найден дебаг!");
                Console.WriteLine("Введите действие (+, -, *, /) ");
                z = Convert.ToChar(Console.ReadLine());

                switch (z)
                {
                    case '+':
                        Console.WriteLine("{0}+{1}={2}", a, b, a + b);
                        break;
                    case '-':
                        Console.WriteLine("{0}-{1}={2}", a, b, a - b);
                        break;
                    case '*':
                        Console.WriteLine("{0}*{1}={2}", a, b, a * b);
                        break;
                    case '/':
                        Console.WriteLine("{0}/{1}={2}", a, b, a / b);
                        break;
                    default:
                        log.Error("Мной найден дебаг!");
                        Console.WriteLine("Ошибка");
                        break;
                }
                Console.ReadLine();
                break;
            }


        }


    }
}
