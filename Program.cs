using event_handler.Entities;

Person person = new() { Name = "Peter Parker", Age = 17 };
person.AgeChanged += Person_AgeChanged;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Exemplo 1");
Console.WriteLine("---------");

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Nome: {person.Name}, Idade: {person.Age}");

person.Age = 18;

static void Person_AgeChanged()
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine("O evento foi acionado! Idade alterada.");
}

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Nome: {person.Name}, Idade: {person.Age}");

Console.WriteLine();
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Exemplo 2");
Console.WriteLine("---------");

Publisher publisher = new();

Subscriber subscriberPeterParker = new("Peter Parker");
Subscriber subscriberMaryJane = new("Mary Jane");

publisher.CustomEvent += subscriberPeterParker.OnCustomEvent;
publisher.CustomEvent += subscriberMaryJane.OnCustomEvent;

publisher.PerformAction();