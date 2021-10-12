using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScriptExample2 : MonoBehaviour
{
    delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;


    void Start()
    {
        myMultiDelegate += PowerUp;
        myMultiDelegate += TurnRed;

        if (myMultiDelegate != null)
        {
            myMultiDelegate();
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
