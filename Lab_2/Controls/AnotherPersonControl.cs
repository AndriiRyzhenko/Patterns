using Lab_2.Interfaces;

namespace Lab_2.Controls;

public class AnotherPersonControl : Control
{
    private bool _checkBox;
    public AnotherPersonControl(IMediator mediator) : base(mediator)
    {
    }

    public bool CheckBox
    {
        get { return _checkBox; }

        set
        {
            _checkBox = value;
            _mediator.Notify(Action.SelfDelivery, value);
        }
    }
}

