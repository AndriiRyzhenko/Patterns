using Lab_4;

class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();

        Console.WriteLine("Food price without delivery is 100");

        order.Delevery = new SelfDelivery();

        Console.WriteLine($"Self delivery: {order.GetCommonPrice()}");

        order.Delevery = new ExternalDelivery();

        Console.WriteLine($"External delivery: {order.GetCommonPrice()}");

        order.Delevery = new InternalDelivery();

        Console.WriteLine($"Internal delivery: {order.GetCommonPrice()}");

        // Console shows next:
        // Food price without delivery is 100
        // Self delivery: 100
        // External delivery: 103
        // Internal delivery: 110
    }
}
