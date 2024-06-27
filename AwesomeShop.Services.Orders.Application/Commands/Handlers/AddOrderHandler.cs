using AwesomeShop.Services.Orders.Core.Repositories;
using AwesomeShop.Services.Orders.Infrastructure.MessageBus;
using MediatR;

namespace AwesomeShop.Services.Orders.Application.Commands.Handlers
{
    public class AddOrderHandler : IRequestHandler<AddOrder, Guid>
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IMessageBusClient _messageBus;
        public AddOrderHandler(IOrderRepository orderRepository, IMessageBusClient messageClient)
        {
            _orderRepository = orderRepository;
            _messageBus = messageClient;
        }
        public async Task<Guid> Handle(AddOrder request, CancellationToken cancellationToken)
        {
            var order = request.ToEntity();
            
            await _orderRepository.AddAsync(order);

            foreach(var @event in order.Events){
                //ordercreated = oerder-created
                var routingKey = @event.GetType().Name.ToDashCase();
                
                _messageBus.Publish(@event, routingKey, "order-service");
            }

            return order.Id;
        }
    }
}