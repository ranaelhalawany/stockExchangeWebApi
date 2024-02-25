using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using stockExchange.API.Data;
using stockExchange.API.Dtos;
using stockExchange.API.Migrations;
using stockExchange.API.Models;

namespace stockExchange.API.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly StockDBContext _context;


        public OrderRepository(StockDBContext context)
        {
            _context = context;


        }

        public void AddOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public IEnumerable<Order> GetOrdersByUser(string userId)
        {
            if (userId == null)
            {
                // Handle null userId as needed
                return Enumerable.Empty<Order>();
            }

            return _context.Orders
                   .Where(o => o.User_id != null && o.User_id.ToLower() == userId.ToLower())
                   .ToList();
        }
        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders.ToList();

        }


    }
}

