namespace BlazorCycleOfLifeComponents.Models;

public enum LifeCycleStep
{
    SetParametersAsync,
    OnInitialized,
    OnParametersSet,
    OnAfterRender,
    ShouldRender,
    Dispose
}