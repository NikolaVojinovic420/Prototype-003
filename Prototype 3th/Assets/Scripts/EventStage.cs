using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventStage : MonoBehaviour
{
    public Broker broker;
    public GameObject activeEvent;
    public GameObject winWindow;
    public GameObject lossWindow;
    public GameObject shuffleDeck;
    // Start is called before the first frame update
    void Start()
    {
        broker = GameObject.FindWithTag("Broker").GetComponent<Broker>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Exhaust()
    {
        GameObject tmp = activeEvent;
        Destroy(tmp);
        Draw();
    }


    public void Discard()
    {
        GameObject tmp = activeEvent;
        tmp.GetComponent<Transform>().SetParent(broker.decks.eventDecks.history.transform);
        Draw();
    }
    void Draw() //pop
    {
        if (broker.decks.eventDecks.future.transform.childCount <= 0) 
        {
            MoveFromHistoryToFuture(); 
            Reshuffle();
        }
           
        GameObject tmp = broker.decks.eventDecks.future.transform.GetChild(0).gameObject;
        activeEvent = tmp;
        broker.decks.eventDecks.future.transform.GetChild(0).transform.SetParent(gameObject.transform);      //move from future to event stage
    }

    public void MoveFromHistoryToFuture()
    {
        for (int i = 0; i < broker.decks.eventDecks.history.transform.childCount; i++)
            broker.decks.eventDecks.history.transform.GetChild(0).SetParent(broker.decks.eventDecks.future.transform);
    }
    public void Reshuffle()
    {
        for (int i = 0; i < broker.decks.eventDecks.future.transform.childCount; i++)
            broker.decks.eventDecks.future.transform.GetChild(0).SetParent(shuffleDeck.transform);
        int count = shuffleDeck.transform.childCount;
        for (int i = 0; i < count; i++)
            shuffleDeck.transform.GetChild(Random.Range(0, shuffleDeck.transform.childCount)).SetParent(broker.decks.eventDecks.future.transform); // add -1?
    }
}
