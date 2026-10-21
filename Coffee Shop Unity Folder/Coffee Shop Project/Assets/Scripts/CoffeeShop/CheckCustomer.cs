using UnityEngine;

public class CheckCustomer : MonoBehaviour
{
    public static int customersServed = 0;

    void Update()
    {
        if (customersServed == 3)
        {
            Debug.Log("Shift Complete");
            customersServed++;
        }
    }
}
