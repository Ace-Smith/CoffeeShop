using UnityEngine;
using System.Collections;

public class MakingEspressoMachine : MonoBehaviour
{
    public GameObject EspressoCupMachine;
    public GameObject EspressoCounter;

    private void OnEnable()
    {
        StartCoroutine(MakingItem());
    }

    private IEnumerator MakingItem()
    {
        yield return new WaitForSeconds(3);
        PrepStation.stationBusy = false;
        UIText.prepStationBusyBool = false;
        PrepStation.drink = "Espresso";
        UIText.prepStationText = "Click on the customer to give them the item!";
        EspressoCounter.SetActive(true);
        EspressoCupMachine.SetActive(false);
    }
}


