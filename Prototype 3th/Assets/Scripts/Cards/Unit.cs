using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    public Aspects aspects;
    public UnitDisplay unitDisplay;
    public Broker broker;
    public string unitName;
    // Start is called before the first frame update
    void Start()
    {
        broker = GameObject.FindWithTag("Broker").GetComponent<Broker>();
        unitDisplay = GameObject.FindWithTag("UnitDisplay").GetComponent<UnitDisplay>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EnageDisengage()
    {
        if (gameObject.transform.parent.gameObject == broker.decks.unitDecks.vigilant)
            gameObject.transform.SetParent(broker.decks.unitDecks.engaged.transform);
        else gameObject.transform.SetParent(broker.decks.unitDecks.vigilant.transform);

        unitDisplay.SortHandDeckAndDisplay();
    }

    public void OnMouseDown()
    {
        EnageDisengage();
    }

}
