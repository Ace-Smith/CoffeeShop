using UnityEngine;

public class Order : MonoBehaviour
{
    private float _costOfCoffee = 4f;
    public int coffeeAmountOrdered;
    public float totalOrderAmount;

    public void AmountPlaced(int coffeeAmountOrdered)
    {
        totalOrderAmount = coffeeAmountOrdered *_costOfCoffee;
        Debug.Log("Your order amount today is " + "£" + totalOrderAmount);
    }
}
