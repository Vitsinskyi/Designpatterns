namespace Observer;

public abstract class LightNode
{
    public abstract string OuterHtml { get; }
    public abstract string InnerHtml { get; }
    public Dictionary<string, List<Action>> EventListeners { get; } = new Dictionary<string, List<Action>>();
    
    public void AddEventListener(string eventType, Action callback)
    {
        if (!EventListeners.ContainsKey(eventType))
            EventListeners[eventType] = new List<Action>();
        EventListeners[eventType].Add(callback);
    }

    public void TriggerEvent(string eventType)
    {
        if (EventListeners.ContainsKey(eventType))
        {
            foreach (var callback in EventListeners[eventType])
                callback();
        }
    }
}