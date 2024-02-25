using System;
using stockExchange.API.Models;
using stockExchange.API.Repositories;
using stockExchange.API.Interfaces;
using stockExchange.API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace stockExchange.API.Services
{
    public class OrderService : IOrderService
    {  
        private readonly IOrderRepository _OrderRepository;

        public OrderService(IOrderRepository OrderRepository)
        {
            _OrderRepository = OrderRepository;
        }

        public Order CreateOrder(string userId, OrderRequestDto OrderRequest)
        {

            Order newOrder = new Order
            {
                User_id = userId,
                Stock_symbol = OrderRequest.Stock_symbol,
                Order_type = OrderRequest.Order_type,
                Quantity = OrderRequest.Quantity,
                Timestamp = DateTime.UtcNow
            };

            _OrderRepository.AddOrder(newOrder);

            return newOrder;
        }

        public IEnumerable<Order> GetOrders(string userId)
        {
            var allOrders = _OrderRepository.GetOrders();
            var filteredOrders = allOrders.Where(Order => Order.User_id == userId).ToList();

            return filteredOrders;


        }
        public IEnumerable<Order> GetAllOrders()
        {
            return _OrderRepository.GetOrders();



        }
    }
}

