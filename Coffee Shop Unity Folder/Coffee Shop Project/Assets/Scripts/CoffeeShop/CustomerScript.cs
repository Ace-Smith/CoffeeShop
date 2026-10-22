using UnityEditor;
using UnityEngine;

public class CustomerScript : MonoBehaviour
{
    [SerializeField] public static string order = "0";
    public string[] menu = {"Latte", "Espresso", "Tea", "Donut"};
    private int orderNum;
    void OnMouseDown()
    {
        if (order == "0")
        {
            order = GenerateOrder();
            UIText.generalText = "I would like " + order;
        }
        else
        {
            if (PrepStation.drink == order)
            {
                UIText.generalText = "Order correct!";
                CheckCustomer.customersServed++;
                order = "0";
                PrepStation.drink = "0";
                UIText.prepStationText = " ";
            }
            else if (PrepStation.drink == "0")
            {
                UIText.generalText = "Need to make an item first";
            }
            else
            {
                UIText.generalText = "Order incorrect. Try again";
                PrepStation.drink = "0";
                UIText.prepStationText = " ";
            }
        }
    }

    private string GenerateOrder()
    {
        int orderNum = Random.Range(0, 4);
        return menu[orderNum];
    }
}
