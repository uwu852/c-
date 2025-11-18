using RestaurantSystem.Menu;
using RestaurantSystem.Orders;
using System;
using System.Collections.Generic;
using System.Linq;
using RestaurantSystem.Menu;

namespace RestaurantSystem.Orders
{
    public class Restaurant
    {
        private readonly List<MenuItem> _menu = new();
        private readonly List<Order> _orders = new();
        private int _nextOrderId = 1;

        public void AddMenuItem(MenuItem item)
        {
            _menu.Add(item);
        }

        public void ShowMenu()
        {
            Console.WriteLine("--- МЕНЮ РЕСТОРАНУ ---");
            int index = 1;

            foreach (var item in _menu)
            {
                Console.WriteLine($"{index}. {item}");
                index++;
            }

            Console.WriteLine("-----------------------\n");
        }

        public Order CreateOrder(int table)
        {
            var order = new Order(_nextOrderId++, table);
            _orders.Add(order);
            Console.WriteLine($"Створено нове замовлення для столика №{table}");
            return order;
        }

        public void ShowAllOrders()
        {
            Console.WriteLine("\n--- УСІ ЗАМОВЛЕННЯ ---");

            foreach (var o in _orders)
            {
                Console.WriteLine($"ID: {o.Id} | Стіл: {o.TableNumber} | Статус: {o.Status} | Сума: {o.GetTotal()} грн");
            }
        }
    }
}
