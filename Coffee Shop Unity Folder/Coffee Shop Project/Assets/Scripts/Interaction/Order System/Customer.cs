using UnityEngine;
using UnityEngine.Events;

public class Customer : MonoBehaviour
{
    //Variables
    public static string drinkType = "Coffee";
    //This is a new keyword for us
    //Static means that it is perclass, and not per instance of a class

    public string exampleVariable = "Tea";

    public UnityEvent raiseOrder;

    void Start()
    {
        RequestDrink(drinkType);
    }

    void RequestDrink(string drinkType)
    {
        Debug.Log(drinkType);
        //raiseOrder?.Invoke();
        Debug.Log(exampleVariable);
    }
}
