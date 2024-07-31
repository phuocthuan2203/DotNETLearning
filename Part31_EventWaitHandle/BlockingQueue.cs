namespace Part31_EventWaitHandle;

public class BlockingQueue<T>
{
    private readonly List<T> _queue = [];

    public void EnQueue(T item)
    {
        _queue.Add(item);
    }

    public T DeQueue()
    {
        var item = _queue.First();
        _queue.RemoveAt(0);
        return item;
    }
}