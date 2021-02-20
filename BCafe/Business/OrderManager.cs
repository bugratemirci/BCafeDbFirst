using BCafe.DataAccess;
using BCafe.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BCafe.Business
{
    public class OrderManager : IOrderService
    {
        IOrderDal orderDal_;

        public OrderManager(IOrderDal orderDal_)
        {
            this.orderDal_ = orderDal_;
        }

        public void Add(Order order)
        {
            orderDal_.Add(order);
        }

        public void Delete(Order order)
        {
            orderDal_.Delete(order);
        }

        public List<Order> GetAll()
        {
            return orderDal_.GetAll();
        }

        public void Update(Order order)
        {
            orderDal_.Update(order);
        }

        public Product getOrderPrice(int id)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                return bCafeEntities.Products.SingleOrDefault(p => p.Id == id);
            }
        }
        public List<OrderDto> ShowOrders()
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var desks = bCafeEntities.Desks;
                var products = bCafeEntities.Products;
                var orders = bCafeEntities.Orders;

                var result = from p in products
                             join o in orders
                             on p.Id equals o.ProductId
                             join d in desks
                             on o.DeskId equals d.Id
                             select new OrderDto { DeskName = d.DeskName, Id = o.Id, OrderPrice = o.OrderPrice, ProductName = p.Name };
                return result.ToList();
            }
        }

        public List<OrderDto> ShowOrders(string deskName)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var desks = bCafeEntities.Desks;
                var products = bCafeEntities.Products;
                var orders = bCafeEntities.Orders;

                var result = from p in products
                             join o in orders
                             on p.Id equals o.ProductId
                             join d in desks
                             on o.DeskId equals d.Id
                             select new OrderDto { DeskName = d.DeskName, Id = o.Id, OrderPrice = o.OrderPrice, ProductName = p.Name };
                return result.Where(r => r.DeskName.Contains(deskName)).ToList();
            }
        }
        public decimal SumofOrders(int deskId)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var desks = bCafeEntities.Desks;
                var orders = bCafeEntities.Orders;
                var result = (from o in orders
                              where o.DeskId == deskId
                              select o.OrderPrice).Sum();
                return result;
            }
        }

        public void Delete(int deskId)
        {
            using (BCafeContext bCafeEntities = new BCafeContext())
            {
                var orders = bCafeEntities.Orders;
                var orderList = (from o in orders
                              where o.DeskId == deskId
                              select o.Id).ToList();
                for (int i = 0; i < orderList.Count(); i++)
                {
                    var result = bCafeEntities.Entry(new Order { Id = orderList[i] });
                    result.State = EntityState.Deleted;
                    
                }
                bCafeEntities.SaveChanges();
            }
        }

        public bool OrderControl(int deskId)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var orders = bCafeEntities.Orders.Any(o => o.DeskId == deskId);
                return orders;
            }
        }
        public Order GetById(int orderId)
        {
            using(BCafeContext bCafeEntities = new BCafeContext())
            {
                var order = bCafeEntities.Orders.SingleOrDefault(o => o.Id == orderId);
                return order;
            }
        }
    }
}
