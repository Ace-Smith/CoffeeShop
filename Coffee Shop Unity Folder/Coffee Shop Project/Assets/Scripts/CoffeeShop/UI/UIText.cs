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
    public static bool prepStationBusyBool;
    public TMP_Text prepStationBusy;
    public TMP_Text ShiftComplete;
    public GameObject RestartButton;

    

    
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
            RestartButton.SetActive(true);
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
    

    

