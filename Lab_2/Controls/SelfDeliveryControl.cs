using Lab_2.Interfaces;

namespace Lab_2.Controls;

public class SelfDeliveryControl : Control
{
    private bool _checkBox;
    public SelfDeliveryControl(IMediator mediator) : base(mediator)
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
