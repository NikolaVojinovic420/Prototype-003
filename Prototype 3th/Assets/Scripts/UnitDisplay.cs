using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitDisplay : MonoBehaviour
{
    public Broker broker;
    public Aspects sumAspect;
    GameObject shuffleDeck;
    // Start is called before the first frame update
    void Start()
    {
        broker = GameObject.FindWithTag("Broker").GetComponent<Broker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Draw()
    {
        if (broker.decks.unitDecks.preparing.transform.childCount <= 0)
        {
            MoveFromRecoveringToPreparing();
            Reshuffle();
        }
        
        broker.decks.unitDecks.preparing.transform.GetChild(0).transform.SetParent(broker.decks.unitDecks.vigilant.transform);
    }
    public void MoveFromRecoveringToPreparing()
    {
        for (int i = 0; i < broker.decks.unitDecks.recovering.transform.childCount; i++)
            broker.decks.unitDecks.recovering.transform.GetChild(0).SetParent(broker.decks.unitDecks.preparing.transform);
    }
    public void Reshuffle()
    {
        for (int i = 0; i < broker.decks.unitDecks.preparing.transform.childCount; i++)
            broker.decks.unitDecks.preparing.transform.GetChild(0).SetParent(shuffleDeck.transform);
        int count = shuffleDeck.transform.childCount;
        for (int i = 0; i < count; i++)
            shuffleDeck.transform.GetChild(Random.Range(0, shuffleDeck.transform.childCount)).SetParent(broker.decks.unitDecks.preparing.transform);
    }
}
