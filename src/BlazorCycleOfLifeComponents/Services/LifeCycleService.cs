namespace BlazorCycleOfLifeComponents.Services;

public class LifeCycleService
{
    public List<BaseCycleComponent> Components { get; init; } = new();

    public void Register(BaseCycleComponent component)
    {
        ArgumentNullException.ThrowIfNull(component);
        if (!Components.Contains(component))
        {
            Components.Add(component);
        }
        if (Current == null)
        {
            Current = component;
        }
    } 

    private BaseCycleComponent _current;

    public BaseCycleComponent Current
    {
        get => _current;
        set
        {
            _current = value;
            CurrentChanged?.Invoke();
        }
    }

    public Action CurrentChanged { get; set; }
}
