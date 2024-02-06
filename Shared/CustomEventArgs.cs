namespace event_handler.Shared;

public class CustomEventArgs(string message) : EventArgs
{
    public string Message { get; set; } = message;
}