using Lab_2.Interfaces;

namespace Lab_2.Controls;

public class DateControl : Control
{
    private string _date;
    public DateControl(IMediator mediator) : base(mediator)
    {
    }

    public string Date
    {
        get { return _date; }

        set
        {
            _date = value;
            _mediator.Notify(Action.Date, value);
        }
    }
}
