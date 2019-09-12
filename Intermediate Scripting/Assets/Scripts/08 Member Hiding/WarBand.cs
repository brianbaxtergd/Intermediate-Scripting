using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarBand : MonoBehaviour
{
    void Start()
    {
        Humanoid human = new Humanoid();
        Humanoid enemy = new Enemy();
        Humanoid orc = new Orc();

        // Each humanoid variable contains a reference to a different class in the inheritance hierarchy, yet each call the Humanoid Yell() method.

        human.Yell();
        enemy.Yell();
        orc.Yell();
    }
}
