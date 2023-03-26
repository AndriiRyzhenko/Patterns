using Lab_2.Controls;

namespace Lab_2.Interfaces
{
    public interface IMediator
    {
        List<Control> Controls { get; set; }
        void Notify(Action action, object parameter);
    }
}
