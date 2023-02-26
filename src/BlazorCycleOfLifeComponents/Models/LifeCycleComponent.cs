namespace BlazorCycleOfLifeComponents.Models;

// If you think about records here:
//
// Don't use records:  https://github.com/dotnet/aspnetcore/pull/45604#discussion_r1061091265
// "This record will translate to about 5kB of binary footprint in the native aot image.
// 80% of it is dynamically unreachable code, but it is impossible for the trimmer to prove
// that it is unreachable because a lot of it is behind potentially reachable interfaces."

public class LifeCycleEvent
{
    public DateTimeOffset TimeStamp { get; init; } = DateTimeOffset.Now;
    public LifeCycleStep Step { get; init; }
    public object Parameter { get; set; }
}

//public class LifeCycleComponent
//{
//    private readonly List<LifeCycleEvent> _events = new();

//    public BaseCycleComponent Component { get; set; }

//    public int Count(LifeCycleStep step) => _events.Count(x => x.Step == step);

//    public void AddEvent(LifeCycleStep step)
//    {
//        _events.Add(new LifeCycleEvent
//        {
//            Step = step
//        });
//    }
//}
