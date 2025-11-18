using RestaurantSystem;
using RestaurantSystem.Menu;
using RestaurantSystem.Orders;
using System.Text;

internal class Program
{
    private static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        var restaurant = new Restaurant();

  
        restaurant.AddMenuItem(new Food("Борщ", 120, Category.Перше));
        restaurant.AddMenuItem(new Drink("Кава", 200, false, 60));
        restaurant.AddMenuItem(new Drink("Сік апельсиновий", 250, false, 70));

        restaurant.ShowMenu();

      
        var order = restaurant.CreateOrder(5);

        order.AddItem(new Food("Борщ", 120, Category.Перше));
        order.AddItem(new Drink("Кава", 200, false, 60));

        Console.WriteLine($"Поточна сума: {order.GetTotal()} грн\n");

        Console.WriteLine($"Статус замовлення: {order.Status}");
        order.SetStatus(OrderStatus.Впроцесі);
        order.SetStatus(OrderStatus.Готове);
        order.SetStatus(OrderStatus.Оплачене);

        restaurant.ShowAllOrders();
    }
}
