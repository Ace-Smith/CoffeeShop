using UnityEngine;

public class DayNightSwitcher : MonoBehaviour
{
    public string Time = "Night";
    private void Start()
    {
        InvokeRepeating(nameof(DayNightToggle), 0.2f, 15f);
    }

    private void DayNightToggle()
    {
        if(Time == "Night")
        {
            Time = "Day";
            Debug.Log(Time);
        }
        else if (Time == "Day")
        {
            Time = "Night";
            Debug.Log(Time);
        }
    }
}
