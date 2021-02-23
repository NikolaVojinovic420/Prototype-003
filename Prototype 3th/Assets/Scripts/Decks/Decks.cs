using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Decks : MonoBehaviour
{
    public GameObject eventDecksObj;
    public EventDecks eventDecks;
    public GameObject unitDecksObj;
    public UnitDecks unitDecks;
    // Start is called before the first frame update
    void Start()
    {
        eventDecks = eventDecksObj.GetComponent<EventDecks>();
        unitDecks = unitDecksObj.GetComponent<UnitDecks>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
