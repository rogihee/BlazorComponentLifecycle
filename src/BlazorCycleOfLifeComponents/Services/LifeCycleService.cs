namespace BlazorCycleOfLifeComponents.Services;

public class LifeCycleService
{
    private static int _instanceCounter = 0;

    public List<LifeCycleHistory> Components { get; init; } = new();

    public LifeCycleHistory Register<T>(T component) where T: BaseCycleComponent
    {
        ArgumentNullException.ThrowIfNull(component);
        var res = new LifeCycleHistory
        {
            ComponentType = typeof(T),
            InstanceId = _instanceCounter++
        };
        Components.Add(res);
        Current ??= component;
        return res;
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
