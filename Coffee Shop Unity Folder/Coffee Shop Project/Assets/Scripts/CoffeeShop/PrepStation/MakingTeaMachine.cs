using UnityEngine;
using System.Collections;

public class MakingTeaMachine : MonoBehaviour
{
    public GameObject TeaMugMachine;
    public GameObject TeaCounter;

    void OnEnable()
    {
        StartCoroutine(MakingItem());
        
    }

    private IEnumerator MakingItem()
    {
        yield return new WaitForSeconds(6);
        PrepStation.stationBusy = false;
        UIText.prepStationBusyBool = false;
        PrepStation.drink = "Tea";
        UIText.prepStationText = "Click on the customer to give them the item!";
        TeaCounter.SetActive(true);
        TeaMugMachine.SetActive(false);
    }
}
