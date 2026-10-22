using UnityEngine;
using System.Collections;

public class MakingTea : MonoBehaviour
{
    public float countdown = 6f;
    void OnMouseDown()
    {
        if (PrepStation.stationBusy == false)
        {
            if (PrepStation.drink != "0")
            {
                UIText.prepStationText = "Can only have one item at a time";
            }
            else
            {
                PrepStation.stationBusy = true;
                countdown = 10;
                UIText.prepStationText = "Prep station making Tea";
                StartCoroutine(MakingItem());
            }
        }
        else if (PrepStation.stationBusy == true)
        {
            UIText.prepStationBusyBool = true;
        }
    }
    
    private IEnumerator MakingItem()
    {
        yield return new WaitForSeconds(countdown);
        PrepStation.stationBusy = false;
        UIText.prepStationBusyBool = false;
        PrepStation.drink = "Tea";
        UIText.prepStationText = "Click on the customer to give them the item!";
    }
}
