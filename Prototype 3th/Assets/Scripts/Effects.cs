using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public bool win;
    public bool loss;
    public bool exhaust;
    public int draw;

    EventStage eventStage;

    // Start is called before the first frame update
    void Start()
    {
        eventStage = GameObject.FindWithTag("EventStage").GetComponent<EventStage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Execute()
    {
        //if (exhaust)
        //    eventStage.Exhaust();
        //else eventStage.Discard();
    }
}
