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
    public TMP_Text controls;
    public TMP_Text visiblePrepStationText;
    public static string prepStationText = " ";
    public TMP_Text currentItem;
    

    void Start()
    {
        controls.text = "Click on customer to get their order and deliver items. Click on items to make them.";
        currentItem.text = " ";
    }
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
            currentItem.text = "Current item: " + PrepStation.drink;
        }
        else
        {
            currentItem.text = " ";
        }
    }
    private IEnumerator generalTextCountdown()
    {
        yield return new WaitForSeconds(5);
        generalText = " ";
    }
    
}
    

    

