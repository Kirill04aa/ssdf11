// See https://aka.ms/new-console-template for more information
using System.Runtime.ConstrainedExecution;
{
     static void Main(string[] args)
    {
        Random r = new Random();
        int n=r.Next(50);
        Console.WriteLine("Угадайте число от 0 до 50");
        Console.WriteLine("Ваш ответ");

        int x = 1;
        int a = Convert.ToInt32(x);
        Console.ReadLine();
        while (x <= 3)
        {
            x++;
            if (a == n)
            {
                Console.WriteLine("У вас получилось угадать с " + x + "попытки");
                break;


            }
            else
            {
                Console.WriteLine("Вы не угадали число, использовав" + x + ":");
                a = Convert.ToInt32(x);
                Console.ReadLine();
                if (x == 3)
                {
                    Console.WriteLine("У вас не получилось угадать число :с");
                    break;
                }
            
           
                    
            }
        }

    }
}
