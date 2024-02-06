using event_handler.Shared;

namespace event_handler.Entities;

public class Subscriber(string name)
{
    private readonly string _name = name;

    public void OnCustomEvent(object? sender, CustomEventArgs e)
    {
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine($"O evento foi acionado! { _name } recebeu a seguinte mensagem: { e.Message }");
    }
}