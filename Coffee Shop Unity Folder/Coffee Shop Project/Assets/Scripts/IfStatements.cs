using UnityEngine;

public class IfStatements : MonoBehaviour
{
    bool coffeeMachineOn = true;

    void Start()
    {
        if (!coffeeMachineOn)
        {
            Debug.Log("Brewing coffee...");
        }
        else
        {
            Debug.Log("Machine not on");
        }
    }
}
