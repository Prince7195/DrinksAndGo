using DrinkAndGo.Data.Interfaces;
using DrinkAndGo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkAndGo.Data.Repositories
{
    public class OrderRepository : IOrderRepository
    {

        private readonly AppDBContext _appDBContext;
        private readonly ShoppingCart _shoppingCart;


        public OrderRepository(AppDBContext appDBContext, ShoppingCart shoppingCart)
        {
            _appDBContext = appDBContext;
            _shoppingCart = shoppingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced = DateTime.Now;

            _appDBContext.Orders.Add(order);

            var shoppingCartItems = _shoppingCart.ShoppingCartItems;

            foreach (var shoppingCartItem in shoppingCartItems)
            {
                var orderDetail = new OrderDetail()
                {
                    Amount = shoppingCartItem.Amount,
                    DrinkId = shoppingCartItem.Drink.DrinkId,
                    OrderId = order.OrderId,
                    Price = shoppingCartItem.Drink.Price
                };

                _appDBContext.OrderDetails.Add(orderDetail);
            }

            _appDBContext.SaveChanges();
        }
    }
}
