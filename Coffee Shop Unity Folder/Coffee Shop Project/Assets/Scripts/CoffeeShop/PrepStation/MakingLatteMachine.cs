using UnityEngine;
using System.Collections;

public class MakingLatteMachine : MonoBehaviour
{
    public GameObject LatteCupMachine;
    public GameObject LatteCounter;

    private void OnEnable()
    {
        StartCoroutine(MakingItem());
    }

    private IEnumerator MakingItem()
    {
        yield return new WaitForSeconds(6);
        PrepStation.stationBusy = false;
        UIText.prepStationBusyBool = false;
        PrepStation.drink = "Latte";
        UIText.prepStationText = "Click on the customer to give them the item!";
        LatteCounter.SetActive(true);
        LatteCupMachine.SetActive(false);
    }
}
