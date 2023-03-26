using Lab_2.Interfaces;

namespace Lab_2.Controls;

public class TimeControl : Control
{
    private string _date;
    public TimeControl(IMediator mediator) : base(mediator)
    {
    }

    public void SetTimeRange(string date)
    {
        Console.WriteLine("SetTimeRange");
    }

    public string Time
    {
        get { return _date; }

        set
        {
            _date = value;
            _mediator.Notify(Action.Time, value);
        }
    }
}