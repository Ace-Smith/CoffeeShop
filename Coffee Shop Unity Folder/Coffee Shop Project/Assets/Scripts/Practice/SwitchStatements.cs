using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchStatements : MonoBehaviour
{
    public enum CoffeeType
    {
        Espresso,
        Latte,
        Cappuccino,
        Americano,
        Mocha,
        NitroColdBrew,
        None
    }

    [SerializeField] private CoffeeType coffeeOrder;

    // void Start()
    // {
    //     switch(coffeeOrder)
    //     {
    //         case "Espresso":
    //             Debug.Log("Making an Espresso.");
    //             break;
    //         case "Latte":
    //             Debug.Log("Making a Latte");
    //             break;
    //         case "Cappuccino":
    //             Debug.Log("Making a Cappuccino");
    //             break;
    //         default:
    //             Debug.Log("Sorry, we don't have that drink on the menu.");
    //             break;
    //     }
    // }
}
