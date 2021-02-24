using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Event : MonoBehaviour
{
    public EventStage eventStage;
    public Broker broker;
    public string eventName;
    // Start is called before the first frame update
    void Start()
    {
        broker = GameObject.FindWithTag("Broker").GetComponent<Broker>();
        eventStage = GameObject.FindWithTag("EventStage").GetComponent<EventStage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
