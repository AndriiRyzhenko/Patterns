using Lab_3.Interfaces;

namespace Lab_3;
public class NotificationSettingsMemento : INotificationSettingsMemento
{
    public bool All { get; }
    public bool OnlyImportant { get; }
    public bool SecurityUpdate { get; }
    public bool Never { get; }

    public NotificationSettingsMemento(bool all, bool onlyImportant, bool securityUpdate, bool never)
    {
        All = all;
        OnlyImportant = onlyImportant;
        SecurityUpdate = securityUpdate;
        Never = never;
    }
}
