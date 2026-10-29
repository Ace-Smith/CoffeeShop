using UnityEngine;
using System.Collections;

public class MakingEspresso : MonoBehaviour
{
    private int countdown = 3;
    public GameObject EspressoCup;
    public GameObject EspressoCupMachine;
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
                countdown = 3;
                PrepStation.stationBusy = true;
                UIText.prepStationText = "Prep station making Espresso";
                EspressoCup.SetActive(false);
                EspressoCupMachine.SetActive(true);
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
        yield return new WaitForSeconds(3);
        PrepStation.stationBusy = false;
        UIText.prepStationBusyBool = false;
        PrepStation.drink = "Espresso";
        UIText.prepStationText = "Click on the customer to give them the item!";
        EspressoCupMachine.SetActive(false);
    }
}
