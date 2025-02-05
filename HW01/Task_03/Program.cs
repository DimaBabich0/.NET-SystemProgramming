using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static bool keyPressed = false;

        static void Main()
        {
            Thread keyListener = new Thread(WaitForKeyPress);
            keyListener.Start();

            Thread gameThread = new Thread(new ThreadStart(Game));
            gameThread.Start();
        }

        static void WaitForKeyPress()
        {
            Console.ReadKey();
            keyPressed = true;
        }

        static void Game()
        {
            Random r = new Random();
            Console.WriteLine("Wait...");
            Thread.Sleep(r.Next(1000, 3000));

            if (keyPressed)
            {
                Console.WriteLine("You pressed a key before the signal");
                return;
            }

            DateTime now = DateTime.Now;
            Console.WriteLine("Press any button!");
            
            while (!keyPressed) { }

            TimeSpan result = DateTime.Now - now;
            Console.WriteLine($"Time between: {result.Seconds}.{result.Milliseconds}");
        }
    }
}
