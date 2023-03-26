using Lab_2.Interfaces;

namespace Lab_2.Controls
{
    public abstract class Control
    {
        protected IMediator _mediator;
        public bool IsEnabled { get; set; } = true;
        protected Control(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
