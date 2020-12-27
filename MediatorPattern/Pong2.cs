using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Pong2 : INotificationHandler<Ping>
    {
        public Task Handle(Ping notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Pong 2 Msg:{notification.Msg}");
            return Task.CompletedTask;
        }
    }
}
