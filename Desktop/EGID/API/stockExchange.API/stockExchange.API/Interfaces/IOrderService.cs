using System;
using Microsoft.AspNetCore.Mvc;
using stockExchange.API.Dtos;
using stockExchange.API.Models;


namespace stockExchange.API.Interfaces
{
    public interface IOrderService
    {
        Order CreateOrder(string userId,OrderRequestDto OrderRequest);
        IEnumerable<Order> GetOrders(string userId);
        IEnumerable<Order> GetAllOrders();



    }
}

