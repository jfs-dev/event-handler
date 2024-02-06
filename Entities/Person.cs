namespace event_handler.Entities;

public class Person
{
    private int _age;

    public event Action? AgeChanged;

    public string Name { get; set; } = string.Empty;

    public int Age
    {
        get { return _age; }
        set
        {
            if (_age != value)
            {
                _age = value;
                OnAgeChanged();
            }
        }
    }

    protected virtual void OnAgeChanged() => AgeChanged?.Invoke();
}