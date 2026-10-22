using UnityEngine;

public class ClearDrink : MonoBehaviour
{
    private void OnMouseDown()
    {
        if (PrepStation.drink != "0")
        {
            PrepStation.drink = "0";
        }
    }
}
