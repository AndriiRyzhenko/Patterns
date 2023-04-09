using Lab_4.Interfaces;

namespace Lab_4;

public class Order
{
    public IDelivery Delevery { get; set; }

    public int GetCommonPrice()
    {
        // conditional cost of the food in the basket
        int mealPrice = 100;
        return mealPrice + Delevery.Cost();
    }
}

