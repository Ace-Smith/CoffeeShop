using UnityEngine;
using System.Collections;

public class MakingEspresso : MonoBehaviour
{
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
                
                PrepStation.stationBusy = true;
                UIText.prepStationText = "Prep station making Espresso";
                EspressoCup.SetActive(false);
                EspressoCupMachine.SetActive(true);
                
            }
        }
        else if (PrepStation.stationBusy == true)
        {
            UIText.prepStationBusyBool = true;
        }
    }
    
}
