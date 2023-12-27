using AwesomeShop.Services.Customers.Core.Entities;
using System;
using System.Threading.Tasks;

namespace AwesomeShop.Services.Customers.Core.Repositories
{
    public interface IOrderRepository
    {
        Task<Order> GetByIdAsync(Guid id);
        Task AddAsync(Order order);
        Task UpdateAsync(Order order);
    }
}
