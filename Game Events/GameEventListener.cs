using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [Header("GameEvent reference")] [SerializeField]
    public GameEvent Event;

    [Header("Response to the Event")] [SerializeField]
    public UnityEvent Response;

    // OnEnable register the responses.
    private void OnEnable() => Event.RegisterListener(this);
    
    // OnDisable register the responses.
    private void OnDisable() => Event.UnregisterListener(this);
    
    // OnEventRaised invoke the response.
    public void OnEventRaised() => Response.Invoke();
}