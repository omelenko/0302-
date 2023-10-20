using System;
using System.Threading;

class Program
{
    static int freq = 200, dura = 1000;
    static void Main()
    {
        Thread thread = new Thread(new ThreadStart(() => Worker()));
        Thread thread1 = new Thread(new ThreadStart(() => Worker1()));
        thread.Start();
        thread1.Start();
        thread.Join();
        thread1.Join();
    }

    static void Worker()
    {
        for (int i = 0; i < 100; i++)
        {
            generateSoundAndSleep(freq, dura, 500);
            freq += 18;
        }
    }
    static void Worker1()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"Частота: {freq}");
            Thread.Sleep(1500);
        }
    }

    static void generateSoundAndSleep(int freq, int dura, int sleep)
    {
        Console.Beep(freq, dura);
        Thread.Sleep(sleep);
    }
}
