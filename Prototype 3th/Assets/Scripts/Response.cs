using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Response : MonoBehaviour
{
    public string responseName;
    public Broker broker;

    public Aspects req;
    public Effects effects;

    //add clickable / or different color etc...

    // Start is called before the first frame update
    void Start()
    {
        broker = GameObject.FindWithTag("Broker").GetComponent<Broker>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("HitO");
        RespondToEvent();
    }

    public void RespondToEvent()
    {
        if(Applicable())
        effects.Execute();
    }
    bool Applicable() => broker.unitDisplay.sumAspectEngaged.CanPay(req);

}
