using UnityEngine;
using System.Collections;

public class MakingEspresso : MonoBehaviour
{
    private int countdown = 10;
    void OnMouseDown()
    {
        if (PrepStation.stationBusy == false)
        {
            PrepStation.stationBusy = true;
            countdown = 10;
            UIText.prepStationText = "Prep station making Espresso";
            StartCoroutine(MakingItem());
        }
        else if (PrepStation.stationBusy == true)
        {
            UIText.prepStationText = UIText.prepStationText + ". Prep station is currently busy. Try again later";
        }
    }
    private IEnumerator MakingItem()
    {
        yield return new WaitForSeconds(countdown);
        UIText.prepStationText = "Espresso is ready!";
        PrepStation.stationBusy = false;
        PrepStation.drink = "Espresso";
        UIText.prepStationText = "Click on the customer to give them the item!";
    }
}
