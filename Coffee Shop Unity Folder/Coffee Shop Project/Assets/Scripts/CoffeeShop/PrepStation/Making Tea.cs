using UnityEngine;
using System.Collections;

public class MakingTea : MonoBehaviour
{
    public float countdown = 10f;
    void OnMouseDown()
    {
        if (PrepStation.stationBusy == false)
        {
            PrepStation.stationBusy = true;
            countdown = 10;
            Debug.Log("Prep station making Tea");
            StartCoroutine(MakingItem());
        }
        else if (PrepStation.stationBusy == true)
        {
            Debug.Log("Prep station is currently busy. Try again later");
        }
    }
    
    private IEnumerator MakingItem()
    {
        yield return new WaitForSeconds(countdown);
        Debug.Log ("Tea is ready!");
        PrepStation.stationBusy = false;
        PrepStation.drink = "Tea";
        Debug.Log("Click on the customer to give them the item!");
    }
}
