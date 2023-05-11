namespace BlazorCycleOfLifeComponents.Models;

public enum LifeCycleStep
{
    SetParametersAsync,
    OnInitialized,
    OnParametersSet,
    ShouldRender,
    OnAfterRender,
    Dispose
}