using UnityEngine;

public class MakingEspresso : MonoBehaviour
{
    private int countdown = 10;
    void OnMouseDown()
    {
        if (PrepStation.stationBusy == false)
        {
            PrepStation.stationBusy = true;
            countdown = 10;
            Debug.Log("Prep station making Espresso");
            InvokeRepeating(nameof(CreatingItem), 0.1f, 1f);
        }
        else if (PrepStation.stationBusy == true)
        {
            Debug.Log("Prep station is currently busy. Try again later");
        }
    }
    void CreatingItem()
    {
        Debug.Log("Espresso will be ready in: " + countdown);
        countdown = countdown - 1;
        if (countdown == 0)
        {
            CancelInvoke();
            Debug.Log("Espresso is ready!");
            PrepStation.stationBusy = false;
            PrepStation.drink = "Espresso";
            Debug.Log("Click on the customer to give them the item!");
        }
    }
}
