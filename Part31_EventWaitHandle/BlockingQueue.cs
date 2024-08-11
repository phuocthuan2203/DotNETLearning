namespace Part31_EventWaitHandle;

public class BlockingQueue<T>
{
    private readonly List<T> _queue = [];
    private readonly EventWaitHandle _eventWaitHandle = new(false, EventResetMode.AutoReset);

    public void EnQueue(T item)
    {
        _queue.Add(item);
        _eventWaitHandle.Set(); // turn on the flag
    }

    public T DeQueue()
    {
        _eventWaitHandle.WaitOne();
        
        var item = _queue.First();
        _queue.RemoveAt(0);

        // _eventWaitHandle.Reset(); // reset the flag to "false"
        
        return item;
    }
}