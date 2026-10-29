using UnityEngine;
using System.Collections;

public class CheckCustomer : MonoBehaviour
{
    public static int customersServed = 0;
    public GameObject customer;

    private void Update()
    {
        if (!customer.activeInHierarchy)
        {
            StartCoroutine(SpawnCustomer());
            
        }
    }

    private IEnumerator SpawnCustomer()
    {
        yield return new WaitForSeconds(3);
        customer.SetActive(true);
        
    }
    //public static Instantiate(Object TEMP_customer);

    //void Update()
    //{
    //    if (customersServed == 3)
    //    {
    //        Debug.Log("Shift Complete");
    //        customersServed++;
    //    }
    //}
}
