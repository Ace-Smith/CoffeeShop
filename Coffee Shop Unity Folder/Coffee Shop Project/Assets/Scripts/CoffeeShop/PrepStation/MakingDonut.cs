using UnityEngine;
using System.Collections;

public class MakingDonut : MonoBehaviour
{
    private int countdown = 2;
    public GameObject donut;
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
                countdown = 2;
                PrepStation.stationBusy = true;
                UIText.prepStationText = "Collecting Donut";
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
        yield return new WaitForSeconds(2);
        PrepStation.stationBusy = false;
        UIText.prepStationBusyBool = false;
        PrepStation.drink = "Donut";
        donut.SetActive(false);
        UIText.prepStationText = "Click on the customer to give them the item!";
    }
}
