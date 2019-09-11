using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSalad : MonoBehaviour
{
    void Start()
    {
        // Illustrate inheritance with default constructors.
        Debug.Log("Creating the fruit...");
        Fruit myFruit = new Fruit();
        Debug.Log("Creating the apple...");
        Apple myApple = new Apple();

        // Call methods of the Fruit class.
        myFruit.SayHello();
        myFruit.Chop();

        // Call methods of the Apple class.
        // Apple has access to all of the public thods of class Fruit.
        myApple.SayHello();
        myApple.Chop();

        // Illustrate inheritance with the contructors that read in a string.
        Debug.Log("Creating the fruit...");
        myFruit = new Fruit("yellow");
        Debug.Log("Creating the apple...");
        myApple = new Apple("green");

        // Call methods of the Fruit class.
        myFruit.SayHello();
        myFruit.Chop();

        // Call methods of the Apple class.
        // Apple has access to all of the public methods of class Fruit.
        myApple.SayHello();
        myApple.Chop();
    }
}
