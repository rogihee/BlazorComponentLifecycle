namespace BlazorCycleOfLifeApp.Services;

public class StateService
{
    private int _sharedCounter;

    public int SharedCounter
    {
        get => _sharedCounter;
        set
        {
            _sharedCounter = value;
            NotifyStateChanged();
        }
    }

    public event Action OnChange;

    private void NotifyStateChanged() => OnChange?.Invoke();
}