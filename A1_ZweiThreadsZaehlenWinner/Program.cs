using System;
using System.Threading;

namespace A1_ZweiThreadsZaehlenWinner;

class Program
{
   
    
    public static void Main(string[] args)
    {
        Console.WriteLine("Übung 1: Zwei Threads – Zählen & Winner");
        Thread t1 = new Thread(CountUpThreadA);
        Thread t2 = new Thread(CountDownThreadB);

        t1.Start();
        t2.Start();

        t1.Join();
        t2.Join();
    }
    
    private static void CountUpThreadA()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine($"Thread A: {i}");
            Thread.Sleep(100); // Simuliere Arbeit
        }
    }
    
    private static void CountDownThreadB()
    {
        for (int i = 100; i >= 1; i--)
        {
            Console.WriteLine($"Thread B: {i}");
            Thread.Sleep(100); // Simuliere Arbeit
        }
    }
    }

