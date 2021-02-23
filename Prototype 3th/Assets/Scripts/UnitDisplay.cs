using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitDisplay : MonoBehaviour
{
    public Broker broker;
    public Aspects sumAspect;
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
        
    }

}
