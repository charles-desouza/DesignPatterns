using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;

namespace MediatorPattern
{
    class Program
    {

        //define an object that encapsulates how a set of objects interact
        static void Main(string[] args)
        {
            var services = new ServiceCollection();
            services.AddMediatR(Assembly.GetExecutingAssembly());

            var serviceProvider = services.BuildServiceProvider();

            var mediator = serviceProvider.GetService<IMediator>();

            mediator.Publish(new Ping() { Msg = "ping 1" });

            Console.ReadKey();

            if (serviceProvider is IDisposable)
            {
                ((IDisposable)serviceProvider).Dispose();
            }
        }


    }
}
