using MediatR;

namespace MediatorPattern
{
    public class Ping : INotification
    {
        public string Msg { get; set; }
    }
}
