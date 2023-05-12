namespace BlazorCycleOfLifeApp.Models;

public static class DemoList
{
    private static List<DemoModel> _demos;

    public static List<DemoModel> All
    {
        get
        {
            return _demos ??= new List<DemoModel>
            {
                new()
                {
                    Nr = 1, Component = typeof(CycleButton),
                    Title = "Button with full cycle",
                    Description = "The infamous counter."
                },
                new()
                {
                    Nr = 2, Component = typeof(CounterStateViaService),
                    Title = "Counter via state service",
                    Description = "Update state not via parameters."
                },
                new()
                {
                    Nr = 3, Component = typeof(EventCallbackButton),
                    Title = "Button with only event callback",
                    Description = "Demonstrates that invoking EventCallback causes re-render even with IHandleEvent implemented."
                },
                new()
                {
                    Nr = 4, Component = typeof(CounterViaObjectParameter),
                    Title = "Counter with non-primitive parameter",
                    Description = "Demonstrates that non-primitive parameters always renders. Update only every two clicks but still re-renders every update."
                },
                new()
                {
                    Nr = 5, Component = typeof(CounterRoundToFive),
                    Title = "Counter that only updates every 5 increments",
                    Description = "Demonstrate not all re-renders cause DOM update. Only numbers equal to increments to 5 are rendered."
                }
            };
        }
    }
}

public class DemoModel
{
    public int Nr { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public Type Component { get; set; }
}
