using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Response : MonoBehaviour
{
    public string responseName;

    Aspects aspects;
    Effects effects;

    bool clickable = false; // one or two booleans?

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Debug.Log("HitO");
    }


}
