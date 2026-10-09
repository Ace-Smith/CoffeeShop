using UnityEngine;

public class MakingLatte : MonoBehaviour
{
    private int countdown = 10;
    void OnMouseDown()
    {
        if (PrepStation.stationBusy == false)
        {
            PrepStation.stationBusy = true;
            countdown = 10;
            Debug.Log("Prep station making Latte");
            InvokeRepeating(nameof(CreatingItem), 0.1f, 1f);
        }
        else if (PrepStation.stationBusy == true)
        {
            Debug.Log("Prep station is currently busy. Try again later");
        }
    }
    void CreatingItem()
    {
        Debug.Log("Latte will be ready in: " + countdown);
        countdown = countdown - 1;
        if (countdown == 0)
        {
            CancelInvoke();
            Debug.Log("Latte is ready!");
            PrepStation.stationBusy = false;
            PrepStation.drink = "Latte";
            Debug.Log("Click on the customer to give them the item!");
        }
    }
}
