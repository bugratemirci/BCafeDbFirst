
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCafe.Entities;


namespace BCafe.Business
{
    public interface IOrderService
    {
        List<Order> GetAll();
        void Add(Order order);
        void Update(Order order);
        void Delete(Order order);
        List<OrderDto> ShowOrders();
    }
}
