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
        PrepStation.drink = "Tea";
        UIText.prepStationText = "Click on the customer to give them the item!";
        TeaMugMachine.SetActive(false);
    }
}
