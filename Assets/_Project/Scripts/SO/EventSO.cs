﻿using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

[CreateAssetMenu(fileName = "EventSO", menuName = "SO/Event", order = 0)]
public class EventSO : ScriptableObject
{
    List<SOListener> listeners = new List<SOListener>();

    public void Raise()
    {
        for (int i = 0; i < listeners.Count; i++)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(SOListener listener)
    {
        if (!listeners.Contains(listener)) listeners.Add(listener);
    }

    public void UnregisterListener(SOListener listener)
    {
        if (listeners.Contains(listener)) listeners.Remove(listener);
    }

}
