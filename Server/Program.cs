using System;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(ConverterLibrary.Converter));
            host.Open();
            Console.WriteLine("Сервис запущен");
            Console.ReadLine();
            host.Close();
        }
    }
}
