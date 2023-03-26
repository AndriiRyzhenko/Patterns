using Lab_3.Interfaces;

namespace Lab_3;

public class NotificationSettingsHistory : INotificationSettingsHistory
{
    public Stack<INotificationSettingsMemento> History { get; }
    public NotificationSettingsHistory()
    {
        History = new Stack<INotificationSettingsMemento>();
    }
}

