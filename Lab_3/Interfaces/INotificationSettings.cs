namespace Lab_3.Interfaces;

public interface INotificationSettings
{
    bool All { get; set; }

    bool OnlyImportant { get; set; }

    bool SecurityUpdate { get; set; }

    bool Never { get; set; }

    void ShowSettings();

    INotificationSettingsMemento SaveState();
    void RestoreState(INotificationSettingsMemento memento);
}

