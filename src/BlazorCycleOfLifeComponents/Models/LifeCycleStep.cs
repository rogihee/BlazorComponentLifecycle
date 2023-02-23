namespace BlazorCycleOfLifeComponents.Models;

public enum LifeCycleStep
{
    OnInitialized,
    OnParametersSet,
    OnAfterRender,
    ShouldRender,
    SetParametersAsync,
    Dispose
}