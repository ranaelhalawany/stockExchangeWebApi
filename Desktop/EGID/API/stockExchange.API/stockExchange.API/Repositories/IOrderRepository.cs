using System;
using Microsoft.AspNetCore.Mvc;
using stockExchange.API.Dtos;
using stockExchange.API.Models;

namespace stockExchange.API.Repositories
{
    public interface IOrderRepository
    {
        void AddOrder(Order Order);

        IEnumerable<Order> GetOrdersByUser(string userId);

        IEnumerable<Order> GetOrders();


    }
}

