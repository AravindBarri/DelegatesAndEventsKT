using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScriptExample2 : MonoBehaviour
{
    public delegate void MultiDelegate();
    MultiDelegate myMultiDelegate;
    public static event MultiDelegate delegateEvent;


    void Update()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            delegateEvent();
        }
    }

}
