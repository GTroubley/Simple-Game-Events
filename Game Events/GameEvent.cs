using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> _listeners = new List<GameEventListener>();

    // Use this function to Invoke the response.
    public void InvokeEvent()
    {
        foreach (var gameEventListener in _listeners) gameEventListener.OnEventRaised();
    }

    public void RegisterListener(GameEventListener listener) => _listeners.Add(listener);

    public void UnregisterListener(GameEventListener listener) => _listeners.Remove(listener);
}