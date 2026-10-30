using UnityEngine;
using System.Collections;

public class MakingTea : MonoBehaviour
{
    public float countdown = 6f;
    public GameObject TeaMug;
    public GameObject TeaMugMachine;
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
                countdown = 6f;
                PrepStation.stationBusy = true;
                UIText.prepStationText = "Prep station making Tea";
                TeaMug.SetActive(false);
                TeaMugMachine.SetActive(true);
                
            }
        }
        else if (PrepStation.stationBusy == true)
        {
            UIText.prepStationBusyBool = true;
        }
    }
    
    
}
