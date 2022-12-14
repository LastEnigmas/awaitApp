using System;
using System.Diagnostics;

namespace AppNamespace
{
    class App
    {
        public static async Task Main()
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();

            var myTask = new List<Task> { ReadData() };
            await Task.WhenAll(myTask);

            stw.Stop();

            Console.Write($"\ntime : {stw.Elapsed.TotalMilliseconds}");
            
        }

        public static async Task ReadData()
        {
            string data = await File.ReadAllTextAsync("nameData.txt");
            Console.WriteLine(data);
        }

    }
}