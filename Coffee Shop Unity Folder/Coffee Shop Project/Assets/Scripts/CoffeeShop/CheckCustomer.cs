using UnityEngine;
using System.Collections;

public class CheckCustomer : MonoBehaviour
{
    public static int customersServed = 0;
    public GameObject customer;

    private void Update()
    {
        if (customersServed != 3)
        {
            if (!customer.activeInHierarchy)
            {
                StartCoroutine(SpawnCustomer());
                UIText.CustomerAppearing = "Next customer arriving soon!";
            }
        }
    }

    private IEnumerator SpawnCustomer()
    {
        yield return new WaitForSeconds(5);
        customer.SetActive(true);
        UIText.CustomerAppearing = " ";
    }
    
 
}
