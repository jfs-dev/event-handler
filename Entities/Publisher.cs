using event_handler.Shared;

namespace event_handler.Entities;

public class Publisher
{
    public event EventHandler<CustomEventArgs>? CustomEvent;

    public void PerformAction() =>
        OnCustomEvent("Algo aconteceu no Publisher.");

    protected virtual void OnCustomEvent(string messsage) =>
        CustomEvent?.Invoke(this, new CustomEventArgs(messsage));
}