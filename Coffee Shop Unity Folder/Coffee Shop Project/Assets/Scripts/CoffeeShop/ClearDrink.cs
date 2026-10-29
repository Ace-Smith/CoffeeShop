using UnityEngine;

public class ClearDrink : MonoBehaviour
{
    public GameObject LatteCup;
    public GameObject EspressoCup;
    public GameObject TeaMug;
    public GameObject DonutOne;
    public GameObject DonutTwo;
    private void OnMouseDown()
    {
        if (PrepStation.drink != "0")
        {
            PrepStation.drink = "0";

            LatteCup.SetActive(true);
            EspressoCup.SetActive(true);
            TeaMug.SetActive(true);
            DonutOne.SetActive(true);
            DonutTwo.SetActive(true);
        }

    }
}
