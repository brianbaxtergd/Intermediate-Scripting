using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass : MonoBehaviour
{
    SomeClass inst = new SomeClass();

    public void Start()
    {
        int num = inst.Add(1, 2);
        string str = inst.Add("The", " one");
    }
}
