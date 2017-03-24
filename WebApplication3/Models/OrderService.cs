using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class OrderService
    {
        public void InsertOrder()
        { 
        }

        public void DeleteOrderById() 
        {
        
        }

        public void UpdateOrder()
        { 
        
        }
        public Models.Order GetOrderById(string id)
        {
            return new Models.Order();
        }

        public List<Models.Order> GetOrders()
        {
            return new List<Order>();
        }
    }
}