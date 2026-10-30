using UnityEngine;
using System.Collections;

public class MakingLatte : MonoBehaviour
{
    public GameObject LatteCup;
    public GameObject LatteCupMachine;
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
                    UIText.prepStationText = "Prep station making Latte";
                    LatteCup.SetActive(false);
                    LatteCupMachine.SetActive(true);
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
        yield return new WaitForSeconds(6);
        PrepStation.stationBusy = false;
        UIText.prepStationBusyBool = false;
        PrepStation.drink = "Latte";
        UIText.prepStationText = "Click on the customer to give them the item!";
        LatteCupMachine.SetActive(false);
    }
}
