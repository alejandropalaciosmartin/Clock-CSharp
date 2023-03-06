namespace Reloj
{
    class Proram
    {
        static void Main(string[] args)
        {
            Console.SetCursorPosition(15, 2);
            Console.WriteLine("Mi reloj digital");

            int hours, minutes, seconds;
            DateTime now = DateTime.Now;

            hours = now.Hour;
            minutes = now.Minute;
            seconds = now.Second;

            while (true)//El "while es para que cuando llegue a 24 vuelva a 00
            {
                for (; minutes < 60; minutes++)
                {
                    for (; seconds < 60; seconds++)
                    {
                        Console.SetCursorPosition(20, 10);
                        Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");
                        Thread.Sleep(1000);
                    }
                    seconds = 0;
                }
                minutes = 0;

                hours++;
                if (hours >= 24) hours = 0;
            }
        }
    }
}