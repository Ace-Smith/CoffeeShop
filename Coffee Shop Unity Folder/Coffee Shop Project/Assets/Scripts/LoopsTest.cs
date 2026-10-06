using UnityEngine;

public class LoopsTest : MonoBehaviour
{

    // [SerializeField] private string[] coffeeMenu = {"Espresso", "Latte", "Mocha"};

    // private int beans = 3;

    private int refills = 0;
    private int maxRefills = 3;
    void Start()
    {
        // for (int i = 0; i < 5; i++)
        // {
        //     Debug.Log("Coffee number:" + i);
        // }

        // foreach (string coffee in coffeeMenu)
        // {
        //     Debug.Log("Now serving: " + coffee);
        // }

        // while (beans > 0)
        // {
        //     Debug.Log("Served a coffee. Beans left: " + beans);
        //     beans--;
        // }

        do
        {
            Debug.Log("Serving coffee refill number: " + refills);
            refills++;
        }
        while (refills < maxRefills);
    } 
}
