using UnityEngine;

public class CoffeeShopTest : MonoBehaviour
{
    public int coffeesSold = 0;
    public float coffeePrice = 3.50f;
    public int amountOrdered = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Coffees sold " + coffeesSold);
        Debug.Log("I have ordered");
        Debug.Log(amountOrdered + " coffees");
        amountOrdered++;
        Debug.Log("Oops, I actually ordered " + amountOrdered + " coffees");

        amountOrdered = amountOrdered * 5;
        Debug.Log(amountOrdered);
    }

    // Update is called once per frame
    void Update()
    {
        coffeesSold =+ 1;
    }
}
