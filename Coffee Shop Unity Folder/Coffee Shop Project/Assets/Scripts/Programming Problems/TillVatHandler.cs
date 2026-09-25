using UnityEngine;

public class TillVatHandler : MonoBehaviour
{
    //Varible Decleration
    public float price = 10;
    private float VAT;
    public float totalPrice;

    //Method to call the method
    void Start()
    {
        VATCalculator(price);
        //To check that the price is correct
        Debug.Log(totalPrice);
    }
        
    //Method to calculate the VTA
    public float VATCalculator(float price)
    {
        //Checks if the price entered is less than 0 and if true then returns the price entered
        if (price < 0)
        {
            Debug.Log("Invaild Price");
            return price;
        }
        //Calculating the VAT
        VAT = price * 0.2f;
        //Adding price entered and VAT
        totalPrice = price + VAT;
        //Changes the value of totalPrice to totalPrice rounded to 2 decimal points
        totalPrice = (float)System.Math.Round(totalPrice, 2);
        return totalPrice;
    }
}
