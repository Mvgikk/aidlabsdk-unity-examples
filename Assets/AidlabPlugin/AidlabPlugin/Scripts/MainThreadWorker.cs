using System;
using System.Collections.Generic;
using UnityEngine.Events;

/// <summary>
/// The MainThreadWorker class facilitates execution of Unity events on the main thread.
/// </summary>
/// <remarks>
/// It maintains a queue of Unity events that need to be executed on the main thread.
/// The Update method should be called regularly to process the queued events.
/// </remarks>
public class MainThreadWorker
{
    /// <summary>
    /// Queue of Unity events to be executed on the main thread.
    /// </summary>
    public readonly static Queue<UnityEvent> ExecuteOnMainThread = new Queue<UnityEvent>();

    /// <summary>
    /// Processes the queued Unity events on the main thread.
    /// </summary>
    /// <remarks>
    /// This method should be called regularly, e.g., in the Update loop of a MonoBehaviour.
    /// It dequeues and invokes each Unity event in the queue.
    /// </remarks>
    public void Update()
    {
        while (ExecuteOnMainThread.Count > 0)
        {
            ExecuteOnMainThread.Dequeue().Invoke();
        }
    }
}
