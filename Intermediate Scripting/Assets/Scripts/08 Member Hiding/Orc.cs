using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : Enemy
{
    // This hides the Enemy version of Yell.
    new public void Yell()
    {
        Debug.Log("Orc version of Yell() method.");
    }
}
