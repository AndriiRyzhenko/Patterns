using Lab_2.Interfaces;

namespace Lab_2.Controls;

public class DeliveryInformation : Control
{
    private bool _checkBox;
    public DeliveryInformation(IMediator mediator) : base(mediator)
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
