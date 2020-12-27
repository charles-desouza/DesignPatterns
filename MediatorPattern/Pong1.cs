using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatorPattern
{
    public class Pong1 : INotificationHandler<Ping>
    {
        public Task Handle(Ping notification, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Pong 1 Msg:{notification.Msg}");
            return Task.CompletedTask;
        }
    }
}
