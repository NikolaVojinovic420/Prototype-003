using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnitDisplay : MonoBehaviour
{
    public Broker broker;
    public Aspects sumAspectEngaged;
    public Aspects sumAspectVigilant;
    public  GameObject shuffleDeck;
    public GameObject textVigilant;
    public GameObject textEngaged;

    public int OffsetX = 2;
    


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
        SortHandDeckAndDisplay();
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
    public void SortHandDeckAndDisplay()
    {
        for (int i = 0; i < broker.decks.unitDecks.vigilant.transform.childCount; i++)
        {
            broker.decks.unitDecks.vigilant.transform.GetChild(i).transform.position = 
                new Vector2(broker.decks.unitDecks.vigilant.transform.transform.position.x + i * (OffsetX + broker.decks.unitDecks.vigilant.transform.GetChild(i).transform.localScale.x),
                broker.decks.unitDecks.vigilant.transform.transform.position.y);    
        }
        for (int i = 0; i < broker.decks.unitDecks.engaged.transform.childCount; i++)
        {
            broker.decks.unitDecks.engaged.transform.GetChild(i).transform.position =
                new Vector2(broker.decks.unitDecks.engaged.transform.transform.position.x + i * (OffsetX + broker.decks.unitDecks.engaged.transform.GetChild(i).transform.localScale.x),
                broker.decks.unitDecks.engaged.transform.transform.position.y);
        }

        sumAspectEngaged.Copy(broker.decks.unitDecks.engaged);
        sumAspectVigilant.Copy(broker.decks.unitDecks.vigilant);
        textVigilant.GetComponent<Text>().text = $"Vigilant\n A: {sumAspectVigilant.a}\n P:{sumAspectVigilant.p}\n C:{sumAspectVigilant.c}";
        textEngaged.GetComponent<Text>().text = $"Engaged\n A: {sumAspectEngaged.a}\n P:{sumAspectEngaged.p}\n C:{sumAspectEngaged.c}";

        
        //refresh display here
    }

    public void MoveEngagedToRecovering()
    {
        for (int i = 0; i < broker.decks.unitDecks.engaged.transform.childCount; i++)
        {
            broker.decks.unitDecks.engaged.transform.GetChild(i).SetParent(broker.decks.unitDecks.recovering.transform);
        }
        SortHandDeckAndDisplay();
        broker.unitDisplay.sumAspectEngaged.Copy(broker.decks.unitDecks.engaged);
    }
}
