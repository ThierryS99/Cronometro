using System;
using System.Threading;

namespace StopWatch
{
    class StopWatch
    {
        static void Main()
        {
            Console.Clear();

            Console.Write("PRESSIONE ENTER PARA INICIAR A CONTAGEM:");
            Console.ReadLine();
            Start(7200);
        }
        static void Start(int segundos)
        {
            for (int s1 = 0; s1 <= segundos; s1++) // CONTANDO OS MINUTOS
            {
                for (int s = 0; s <= 60; s++) // CONTANDO OS SEGUNDOS
                {
                    if (s <= 9)
                    {
                        Console.Clear();
                        Console.Write("Tempo: 00:0{0}:0{1}", s1, s);
                        Thread.Sleep(1000);
                    }

                    if (s >= 10 & s <= 59)
                    {
                        Console.Clear();
                        Console.Write("Tempo: 00:0{0}:{1}", s1, s);
                        Thread.Sleep(1000);
                    }
                }
            }
        }
    }
}
