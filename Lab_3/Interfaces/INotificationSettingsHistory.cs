namespace Lab_3.Interfaces
{
    public interface INotificationSettingsHistory
    {
        Stack<INotificationSettingsMemento> History { get; }
    }
}
