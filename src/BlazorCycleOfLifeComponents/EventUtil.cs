namespace BlazorCycleOfLifeComponents;

public static class EventUtil
{
    public static Action AsNonRenderingEventHandler(Action callback)
        => new SyncReceiver(callback).Invoke;

    public static Action<TValue> AsNonRenderingEventHandler<TValue>(
        Action<TValue> callback)
        => new SyncReceiver<TValue>(callback).Invoke;

    public static Func<Task> AsNonRenderingEventHandler(Func<Task> callback)
        => new AsyncReceiver(callback).Invoke;

    public static Func<TValue, Task> AsNonRenderingEventHandler<TValue>(Func<TValue, Task> callback)
        => new AsyncReceiver<TValue>(callback).Invoke;

    private class SyncReceiver : ReceiverBase
    {
        private readonly Action _callback;

        public SyncReceiver(Action callback)
        {
            _callback = callback;
        }

        public void Invoke() => _callback();
    }

    private class SyncReceiver<T> : ReceiverBase
    {
        private readonly Action<T> _callback;

        public SyncReceiver(Action<T> callback)
        {
            _callback = callback;
        }

        public void Invoke(T arg) => _callback(arg);
    }

    private class AsyncReceiver : ReceiverBase
    {
        private readonly Func<Task> _callback;

        public AsyncReceiver(Func<Task> callback)
        {
            _callback = callback;
        }

        public Task Invoke() => _callback();
    }

    private class AsyncReceiver<T> : ReceiverBase
    {
        private readonly Func<T, Task> _callback;

        public AsyncReceiver(Func<T, Task> callback)
        {
            _callback = callback;
        }

        public Task Invoke(T arg) => _callback(arg);
    }

    private class ReceiverBase : IHandleEvent
    {
        public Task HandleEventAsync(EventCallbackWorkItem item, object arg) => 
            item.InvokeAsync(arg);
    }
}