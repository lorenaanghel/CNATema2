using Grpc.Core;
using System;
using System.Globalization;
using System.Threading;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            const string Host = "localhost";
            const int Port = 5001;
            int OK = 1;

            var channel = new Channel($"{Host}:{Port}", ChannelCredentials.Insecure);

            do
            {
                Console.WriteLine("Please enter the date (MM/dd/yyyy): ");
                string data = Console.ReadLine();
                
                do
                {
                    foreach (char ch in data)
                    {
                        if ((ch < '0' || ch > '9') && ch != '/')
                        {
                            OK = 0;
                            Console.WriteLine("Invalid date. Try enter another date.");
                            data = Console.ReadLine();
                        }
                        else
                            OK = 1;
                    }
                } while (OK == 0);
                //Console.WriteLine(data);

                var client = new Generated.SignOperationService.NameOperationServiceClient(channel);

                try
                {
                    var response = client.SayHello(new Generated.SignRequest
                    {
                        Sign = data
                    });

                    Console.WriteLine(response.Message);
                    Thread.Sleep(100);
                }

                catch (Exception e)
                {
                }

            } while (true);

            // Shutdown
            channel.ShutdownAsync().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
