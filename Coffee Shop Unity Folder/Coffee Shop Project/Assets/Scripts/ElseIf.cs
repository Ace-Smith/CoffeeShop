using UnityEngine;

public class ElseIf : MonoBehaviour
{
    int sugarLevel = 2;

    void Start()
    {
        if (sugarLevel == 1)
        {
            Debug.Log("Coffee with 1 spoon of sugar.");
        }
        else if (sugarLevel == 2)
        {
           Debug.Log("Coffee with 2 spoon of sugar.");
        }
        else if (sugarLevel == 3)
        {
            Debug.Log("Coffee with 3 spoon of sugar.");
        }
        else
        {
            Debug.Log("Black coffee,no sugar.");
        }

    }

    
}
