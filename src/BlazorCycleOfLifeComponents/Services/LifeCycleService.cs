namespace BlazorCycleOfLifeComponents.Services;

public class LifeCycleService
{
    private static int _instanceCounter = 0;

    public List<ComponentLifeCycleHistory> Components { get; init; } = new();

    public ComponentLifeCycleHistory Register<T>(T component) where T: BaseCycleComponent
    {
        ArgumentNullException.ThrowIfNull(component);
        var res = new ComponentLifeCycleHistory
        {
            ComponentType = component.GetType(),
            InstanceId = _instanceCounter++
        };
        Components.Add(res);
        ComponentsChanged.Invoke();
        Current ??= res;
        return res;
    }

    public void Clear()
    {
        Components.Clear();
        _instanceCounter = 0;
        ComponentsChanged.Invoke();
    }

    private ComponentLifeCycleHistory _current;

    public ComponentLifeCycleHistory Current
    {
        get => _current;
        set
        {
            _current = value;
            CurrentChanged?.Invoke();
        }
    }

    public Action ComponentsChanged { get; set; }
    public Action CurrentChanged { get; set; }
}
