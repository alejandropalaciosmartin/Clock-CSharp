class Program
{
    static void Main()
    {
        Console.SetCursorPosition(15, 2);
        Console.WriteLine("Mi reloj digital");

        while (true)
        {
            DateTime now = DateTime.Now;
            Console.SetCursorPosition(20, 10);
            Console.WriteLine($"{now:HH:mm:ss}");
            System.Threading.Thread.Sleep(1000);
        }
    }
}