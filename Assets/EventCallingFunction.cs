using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCallingFunction : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DelegateScriptExample2.delegateEvent += PowerUp;
        DelegateScriptExample2.delegateEvent += TurnRed;
        print("Functions added to Event");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            DelegateScriptExample2.delegateEvent -= PowerUp;
            DelegateScriptExample2.delegateEvent -= TurnRed;
            print("Functions removed from Event");
        }
    }
    void PowerUp()
    {
        print("Orb is powering up!");
    }

    void TurnRed()
    {
        print("Now the color is red");
    }

}
