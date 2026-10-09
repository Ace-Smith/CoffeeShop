using UnityEngine;

public class CheckCustomer : MonoBehaviour
{
    public static int customersServed = 0;

    void Start()
    {
        Debug.Log("Need to serve 3 customers to complete your shift");
        Debug.Log("Click on a customer for there order");
    }
    void Update()
    {
        if (customersServed == 3)
        {
            Debug.Log("Shift Complete");
            customersServed++;
        }
    }
}
