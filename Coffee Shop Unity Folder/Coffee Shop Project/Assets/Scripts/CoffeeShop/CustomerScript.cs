using UnityEditor;
using UnityEngine;

public class CustomerScript : MonoBehaviour
{
    public static string order = "0";
    public static string[] menu = {"Latte", "Espresso", "Tea", "Donut"};
    private int orderNum;
    void OnMouseDown()
    {
        if (order == "0")
        {
            order = GenerateOrder();
            Debug.Log(order);
        }
        else
        {
            if (PrepStation.drink == order)
            {
                Debug.Log("Order correct!");
                CheckCustomer.customersServed++;
                Debug.Log("You have served " + CheckCustomer.customersServed + " customers");
                order = "0";
            }
            else
            {
                Debug.Log("Order incorrect. Try again");
            }
        }
    }

    private string GenerateOrder()
    {
        int orderNum = Random.Range(0, 4);
        return menu[orderNum];
    }
}
