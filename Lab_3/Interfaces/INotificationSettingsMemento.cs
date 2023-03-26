namespace Lab_3.Interfaces;

public interface INotificationSettingsMemento
{
    bool All { get; }
    bool OnlyImportant { get; }
    bool SecurityUpdate { get; }
    bool Never { get; }
}

