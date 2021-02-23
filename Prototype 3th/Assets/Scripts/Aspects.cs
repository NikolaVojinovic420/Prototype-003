using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aspects : MonoBehaviour
{
    public int a, p, c;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool Compare(Aspects asp)
    {
        if(a <= asp.a && p <= asp.p && c <= asp.c)
            return true;
        return false;
    }
    
    public void Add(GameObject deck) // this reset aspect
    {
        a = 0;
        p = 0;
        c = 0;
        for (int i = 0; i < deck.transform.childCount; i++)
        {
            Aspects asp = deck.transform.GetChild(i).GetComponent<Aspects>();
            if(asp != null)
            {
                a += asp.a;
                p += asp.p;
                c += asp.c;
            }
        }
    }

}
