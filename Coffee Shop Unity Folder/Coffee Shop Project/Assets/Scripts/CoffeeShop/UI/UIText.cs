using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using TMPro;

public class UIText : MonoBehaviour
{
    public TMP_Text progressText;
    public TMP_Text orderText;
    public static string generalText = " ";
    public TMP_Text visibleGeneralText;
    public TMP_Text visiblePrepStationText;
    public static string prepStationText = " ";
    public TMP_Text currentItem;
    public static bool prepStationBusyBool;
    public TMP_Text prepStationBusy;
    public TMP_Text ShiftComplete;

    

    
    void Update()
    {
        progressText.text = "Progress " + CheckCustomer.customersServed + "/3";

        if (CustomerScript.order == "0")
        {
            orderText.text = "Active order: --";
        }
        else
        {
            orderText.text = "Active order: " + CustomerScript.order;
        }

        visibleGeneralText.text = generalText;


        if (visibleGeneralText.text != " ")
        {
            StartCoroutine(generalTextCountdown()); 
        }


        visiblePrepStationText.text = prepStationText;

        
        if (PrepStation.drink != "0")
        {
            currentItem.text = "Item in hand: " + PrepStation.drink;
        }
        else
        {
            currentItem.text = "Item in hand: --";
        }

        if (prepStationBusyBool == true)
        {
            prepStationBusy.text = "Prep station is currently busy. Try again later";
        }
        else
        {
            prepStationBusy.text = " ";
        }

        if (CheckCustomer.customersServed == 3)
        {
            ShiftComplete.text = "Shift Complete!";
        }
        else
        {
            ShiftComplete.text = " ";
        }

    }
    private IEnumerator generalTextCountdown()
    {
        yield return new WaitForSeconds(5);
        generalText = " ";
    }
    
}
    

    

