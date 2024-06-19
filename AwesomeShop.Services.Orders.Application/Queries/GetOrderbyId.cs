using AwesomeShop.Services.Orders.Application.Dtos.ViewModels;
using MediatR;

namespace AwesomeShop.Services.Orders.Application.Queries
{
    public class GetOrderbyId : IRequest<OrderViewModel>
    {
        public GetOrderbyId(Guid id)
        {
            Id = id;
        }

        public Guid Id { get; private set; }
    }
}