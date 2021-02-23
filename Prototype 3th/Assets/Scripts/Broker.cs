using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Broker : MonoBehaviour
{
    public const string repo = "";
    public GameObject DecksGameObject;
    public UnitDisplay unitDisplay;
    public Decks decks;
    public EventStage eventStage;



    // Start is called before the first frame update
    void Start()
    {
        decks = DecksGameObject.GetComponent<Decks>();
        unitDisplay = GameObject.FindWithTag("UnitDisplay").GetComponent<UnitDisplay>();
        eventStage = GameObject.FindWithTag("EventStage").GetComponent<EventStage>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
