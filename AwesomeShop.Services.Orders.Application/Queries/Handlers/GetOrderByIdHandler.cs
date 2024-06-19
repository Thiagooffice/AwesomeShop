using AwesomeShop.Services.Orders.Application.Dtos.ViewModels;
using AwesomeShop.Services.Orders.Core.Repositories;
using MediatR;

namespace AwesomeShop.Services.Orders.Application.Queries.Handlers
{
    public class GetOrderByIdHandler : IRequestHandler<GetOrderbyId, OrderViewModel>
    {
        private readonly IOrderRepository _orderRepository;
        public GetOrderByIdHandler(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }
        public async Task<OrderViewModel> Handle(GetOrderbyId request, CancellationToken cancellationToken)
        {
            var order = await _orderRepository.GetByAsync(request.Id);

            var orderViewModel = OrderViewModel.FromEntity(order);

            return orderViewModel;
        }
    }
}