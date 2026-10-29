using UnityEditor;
using UnityEngine;

public class CustomerScript : MonoBehaviour
{
    [SerializeField] public static string order = "0";
    public string[] menu = {"Latte", "Espresso", "Tea", "Donut"};
    private int orderNum;
    public GameObject customer;
    public GameObject LatteCup;
    public GameObject EspressoCup;
    public GameObject TeaMug;
    public GameObject DonutOne;
    public GameObject DonutTwo;
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
                customer.SetActive(false);
                ResetItems();
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
                ResetItems();
            }
        }
    }

    private string GenerateOrder()
    {
        int orderNum = Random.Range(0, 4);
        return menu[orderNum];
    }

    public void ResetItems()
    {
        LatteCup.SetActive(true);
        EspressoCup.SetActive(true);
        TeaMug.SetActive(true);
        DonutOne.SetActive(true);
        DonutTwo.SetActive(true);
    }
}
