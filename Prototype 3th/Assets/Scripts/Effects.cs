using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Effects : MonoBehaviour
{
    public bool win;
    public bool loss;
    public bool exhaustable;
    public int draw;
    public GameObject insertEvent;

    Broker broker;
    EventStage eventStage;
    UnitDisplay unitDisplay;

    // Start is called before the first frame update
    void Start()
    {
        broker = GameObject.FindWithTag("Broker").GetComponent<Broker>();
        eventStage = broker.eventStage;
        unitDisplay = broker.unitDisplay;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Execute()
    {
        if (loss)
            eventStage.lossWindow.SetActive(true);
            

        if (win)
            eventStage.winWindow.SetActive(true);

        if (exhaustable)
            eventStage.Exhaust();
        else eventStage.Discard();

        unitDisplay.MoveEngagedToRecovering();

        if (insertEvent != null)
            insertEvent.transform.SetParent(eventStage.broker.decks.eventDecks.history.transform);


        for (int i = 0; i < draw; i++)
            broker.unitDisplay.Draw();
    }
}
