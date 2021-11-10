using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateScript : MonoBehaviour
{
    delegate int MyDelegate();
    MyDelegate myDelegate;
    [SerializeField] int value = 10;


    void Start()
    {
        myDelegate += PrintNum;
        //myDelegate += DoubleNum;
    }

    int PrintNum()
    {
        //print("Print Num: " + value);
        return (value);
    }

    void DoubleNum()
    {
        print("Double Num: " + value * 2);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print(myDelegate());
        }
    }
}
