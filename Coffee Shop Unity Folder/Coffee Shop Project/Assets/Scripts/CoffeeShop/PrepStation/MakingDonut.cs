using UnityEngine;
using System.Collections;

public class MakingDonut : MonoBehaviour
{
    public GameObject donut;
    public GameObject donutCounter;
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
                donutCounter.SetActive(true);
                PrepStation.drink = "Donut";
                donut.SetActive(false);
            }
        }
        else if (PrepStation.stationBusy == true)
        {
            UIText.prepStationBusyBool = true;
        }
    }
   
}
