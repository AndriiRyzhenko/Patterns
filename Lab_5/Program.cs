using Lab_5.Handlers;
using Lab_5.Models;
using Lab_5.Repositories;

class Program
{
    static void Main(string[] args)
    {
        User user = new User { Email = "123@ukr.net", Id = Guid.NewGuid(), Name = "Tom", Password = "qwerty123" };

        Product product = new Product { Id = Guid.NewGuid(), Name = "Boat", Price = 123 };

        Order order = new Order
        {
            Id = Guid.NewGuid(),
            Products = new List<Product>
            {
                product,
                new Product { Id = Guid.NewGuid(), Name = "Car", Price = 321 }
            }
        };

        Handler handler = new UserHandler(new UserRepository());

        var userResponse = handler.Handle(user);
        Console.WriteLine(userResponse);

        handler = new ProductHandler(new ProductRepository());
        var productResponse = handler.Handle(product);
        Console.WriteLine(productResponse);

        handler = new OrderHandler(new OrderRepository());
        var orderResponse = handler.Handle(order);
        Console.WriteLine(orderResponse);


        /*
            Console shows next:

            Code: 400, Status: User email cannot be changed
            Code: 200, Status: Updated
            Code: 200, Status: Updated, Json:
            {
            "Id":"800e6bdb-5d7d-45e3-82e9-f8190c6251c6",
            "Products":[
            {
            "Id":"d4ce6120-9e84-45e3-a63c-895c0719a9dc",
            "Name":"Boat",
            "Price":123
            },
            {
            "Id":"a5fd74bd-e6d0-47f0-8b6c-86725b074f76",
            "Name":"Car",
            "Price":321
            ],
            "TotalPrice":444
            }
         */


    }
}
