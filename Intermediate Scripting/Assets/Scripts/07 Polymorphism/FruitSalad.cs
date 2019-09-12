﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        // The variable "myFruit" is of type Fruit but is being assigned a reference to an Apple. This works because of polymorphism.
        // Since an Apple is a Fruit, this works just fine.
        // While the Apple reference is stored in a Fruit variable, it can only be used like a Fruit.

        Fruit myFruit = new Apple();

        myFruit.SayHello();
        myFruit.Chop();

        // Downcasting.
        // The variable "myFruit" which is of type Fruit actually contains a reference to an Apple.
        // It can safely be turned back into an Apple varaible.
        // This allows it to be used like an Apple, where before it could only be used like a Fruit.

        Apple myApple = (Apple)myFruit;

        myApple.SayHello();
        myApple.Chop();
    }
}
