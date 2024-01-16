using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Aidlab;
using Aidlab.BLE;

public class MainThreadDispatcher : MonoBehaviour
{
    public static MainThreadDispatcher _instance;
    private static readonly Queue<Action> _actionQueue = new Queue<Action>();
    private static readonly object _lock = new object();

    public void Start()
    {
        DontDestroyOnLoad(this.gameObject);
        if (_instance == null)
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = this.GetComponent<MainThreadDispatcher>();
                }
            }
        }
    }

    public static MainThreadDispatcher Instance
    {
        get
        {
            if (_instance != null)
            {
                return _instance;
            }
            else return null;
        }
    }

    //private static void CreateInstance()
    //{
    //    GameObject dispatcherObject = new GameObject("MainThreadDispatcher");
    //    _instance = dispatcherObject.AddComponent<MainThreadDispatcher>();
    //}

    private void Update()
    {
        lock (_actionQueue)
        {
            while (_actionQueue.Count > 0)
            {
                Action action = _actionQueue.Dequeue();
                action.Invoke();
            }
        }
    }

    public void Enqueue(Action action)
    {
        lock (_actionQueue)
        {
            _actionQueue.Enqueue(action);
        }
    }
}