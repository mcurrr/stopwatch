using System;
namespace Timer
{
    class Hello
    {
        static void Main()
        {
            try
            {
                var stopwatch = new Stopwatch();
                Console.WriteLine("Press any key to start timer");
                Console.ReadKey();
                stopwatch.Start();

                Console.WriteLine("Press any key to stop timer");
                Console.ReadKey();
                stopwatch.Stop();

                Console.WriteLine("Press any key to start timer again");
                Console.ReadKey();
                stopwatch.Start();

                Console.WriteLine("Press any key to stop timer");
                Console.ReadKey();
                stopwatch.Stop();

                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception error has occured.");
            }

        }
    }
}