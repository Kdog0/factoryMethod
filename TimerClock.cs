using Pizzaria.Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Timers;

namespace Pizzaria
{
    public class TimerClock1
    {   
        public TimerClock1() {
            string pb;
            Console.CursorVisible = false;
            Console.SetCursorPosition(1, 1);

            System.Timers.Timer timer1 = new(1000);
            timer1.Elapsed += Timer_Elapsed;
            timer1.Start();
            for (int i = 1; i < 50; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    pb = "\u2551";
                    Console.Write(pb);
                }
                Console.Write(i + "/50");
                Console.SetCursorPosition(1, 1);
                Console.ForegroundColor = ConsoleColor.Green;
                Thread.Sleep(200);
                
                timer1.Stop();
                
            }
            Console.Clear();
        }

         public static void Timer_Elapsed(object sender, ElapsedEventArgs e)
         {
            DateTime.Now.ToString();
         } 


    }
    
}
