using Lab_3.Interfaces;

namespace Lab_3;

public class NotificationSettings : INotificationSettings
{
    public bool All { get; set; }
    public bool OnlyImportant { get; set; }
    public bool SecurityUpdate { get; set; }
    public bool Never { get; set; }

    public void ShowSettings()
    {
        Console.WriteLine($"All: {All}");
        Console.WriteLine($"Only Important: {OnlyImportant}");
        Console.WriteLine($"Security Update: {SecurityUpdate}");
        Console.WriteLine($"Never: {Never}");
    }

    public INotificationSettingsMemento SaveState()
    {
        return new NotificationSettingsMemento(All, OnlyImportant, SecurityUpdate, Never);
    }

    public void RestoreState(INotificationSettingsMemento memento)
    {
        All = memento.All;
        OnlyImportant = memento.OnlyImportant;
        SecurityUpdate = memento.SecurityUpdate;
        Never = memento.Never;
    }
}

