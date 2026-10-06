using UnityEngine;

public class LoopsPractice : MonoBehaviour
{
    public int beans = 8;
    public int coffeeCups;
    public string[] coffeeMenu = {"Espresso", "Latte", "Mocha", "Tea"};

    void Start()
    {
        foreach (string coffee in coffeeMenu)
        {
            Debug.Log("Menu item: " + coffee);
        }

        for(int coffeCups = 0; coffeeCups < 10; coffeeCups++)
        {
            Debug.Log("Coffee number: " + coffeeCups);
        }

        while (beans > 0)
        {
            Debug.Log("Coffee served. Beans left: " + beans + ". Coffee cups left: " + coffeeCups);
            beans--;
            coffeeCups--;
        }
    }
}
