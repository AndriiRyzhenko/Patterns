using Lab_2;
using Lab_2.Controls;

class Program
{
    static void Main(string[] args)
    {
        var orderPage = new OrderPage();
        var dateControl = new DateControl(orderPage);
        var anotherPersonControl = new AnotherPersonControl(orderPage);
        var deliveryInformation = new DeliveryInformation(orderPage);
        var selfDeliveryControl = new SelfDeliveryControl(orderPage);
        var timeControl = new TimeControl(orderPage);

        orderPage.Controls = new List<Control>
            {dateControl, selfDeliveryControl, anotherPersonControl, deliveryInformation, timeControl};

        orderPage.ShowEnabledControls();

        selfDeliveryControl.CheckBox = true;

        Console.WriteLine(new string('-', 30));
        orderPage.ShowEnabledControls();

        /*
        Console shows next:

        Lab_2.Controls.DateControl
        Lab_2.Controls.SelfDeliveryControl
        Lab_2.Controls.AnotherPersonControl
        Lab_2.Controls.DeliveryInformation
        Lab_2.Controls.TimeControl
        ------------------------------
        Lab_2.Controls.SelfDeliveryControl
        */
    }
}
