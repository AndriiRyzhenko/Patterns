using Lab_2.Controls;
using Lab_2.Interfaces;

namespace Lab_2
{
    internal class OrderPage : IMediator
    {
        public List<Control> Controls { get; set; }
        public void Notify(Action action, object parameter)
        {
            switch (action)
            {
                case Action.Date:
                    {
                        string date = (string)parameter;
                        var timeControl = Controls.First(x => x.GetType() == typeof(TimeControl));
                        ((TimeControl)timeControl).SetTimeRange(date);
                        break;
                    }
                case Action.AnotherPerson:
                    {
                        var isEnabled = (bool)parameter;
                        if (isEnabled)
                        {
                            Controls.First(x => x.GetType() == typeof(DateControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(SelfDeliveryControl)).IsEnabled = false;
                            Controls.First(x => x.GetType() == typeof(DeliveryInformation)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(TimeControl)).IsEnabled = true;
                        }
                        else
                        {
                            Controls.First(x => x.GetType() == typeof(DateControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(SelfDeliveryControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(DeliveryInformation)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(TimeControl)).IsEnabled = true;
                        }
                        break;
                    }
                case Action.Delivery:
                    {
                        var isEnabled = (bool)parameter;
                        if (isEnabled)
                        {
                            Controls.First(x => x.GetType() == typeof(DateControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(AnotherPersonControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(SelfDeliveryControl)).IsEnabled = false;
                            Controls.First(x => x.GetType() == typeof(TimeControl)).IsEnabled = true;
                        }
                        else
                        {
                            Controls.First(x => x.GetType() == typeof(DateControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(AnotherPersonControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(SelfDeliveryControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(TimeControl)).IsEnabled = true;
                        }
                        break;
                    }
                case Action.SelfDelivery:
                    {
                        var isEnabled = (bool)parameter;
                        if (isEnabled)
                        {
                            Controls.First(x => x.GetType() == typeof(DateControl)).IsEnabled = false;
                            Controls.First(x => x.GetType() == typeof(AnotherPersonControl)).IsEnabled = false;
                            Controls.First(x => x.GetType() == typeof(DeliveryInformation)).IsEnabled = false;
                            Controls.First(x => x.GetType() == typeof(TimeControl)).IsEnabled = false;
                        }
                        else
                        {
                            Controls.First(x => x.GetType() == typeof(DateControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(AnotherPersonControl)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(DeliveryInformation)).IsEnabled = true;
                            Controls.First(x => x.GetType() == typeof(TimeControl)).IsEnabled = true;
                        }
                        break;
                    }
            }
        }

        public void ShowEnabledControls()
        {
            foreach (var item in Controls.Where(x => x.IsEnabled))
            {
                Console.WriteLine(item.GetType());
            }
        }
    }
}
