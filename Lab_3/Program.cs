using Lab_3;
using Lab_3.Interfaces;

class Program
{
    static void Main(string[] args)
    {
        INotificationSettingsHistory notificationSettingsHistory = new NotificationSettingsHistory();

        INotificationSettings notificationSettings = new NotificationSettings();
        notificationSettings.OnlyImportant = true;
        notificationSettings.SecurityUpdate = true;
        notificationSettingsHistory.History.Push(notificationSettings.SaveState());

        notificationSettings.ShowSettings();

        notificationSettings.OnlyImportant = false;
        notificationSettings.SecurityUpdate = false;

        Console.WriteLine(new string('-', 30));
        notificationSettings.ShowSettings();

        notificationSettings.RestoreState(notificationSettingsHistory.History.Pop());

        Console.WriteLine(new string('-', 30));
        notificationSettings.ShowSettings();

        /*
        Console shows next:

        All: False
        Only Important: True
        Security Update: True
        Never: False
        ------------------------------
        All: False
        Only Important: False
        Security Update: False
        Never: False
        ------------------------------
        All: False
        Only Important: True
        Security Update: True
        Never: False
        */
    }
}
