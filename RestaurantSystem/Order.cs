using RestaurantSystem.Menu;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantSystem.Orders
{
    public class Order
    {
        public int Id { get; }
        public int TableNumber { get; }
        public List<MenuItem> Items { get; } = new();
        public OrderStatus Status { get; private set; } = OrderStatus.Нове;

        public Order(int id, int tableNumber)
        {
            Id = id;
            TableNumber = tableNumber;
        }

        public void AddItem(MenuItem item)
        {
            Items.Add(item);
            Console.WriteLine($"Додано позицію: {item.Name}");
        }

        public decimal GetTotal()
        {
            return Items.Sum(i => i.Price);
        }

        public void SetStatus(OrderStatus status)
        {
            Status = status;
            Console.WriteLine($"> Змінено статус: {status}");
        }
    }
}

