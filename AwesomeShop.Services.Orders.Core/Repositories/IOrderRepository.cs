using AwesomeShop.Services.Orders.Core.Entities;

namespace AwesomeShop.Services.Orders.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetByAsync(Guid id);
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
    }
}