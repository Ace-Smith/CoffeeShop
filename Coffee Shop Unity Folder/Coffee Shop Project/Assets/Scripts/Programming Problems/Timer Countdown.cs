using UnityEngine;

public class TimerCountdown : MonoBehaviour
{
    public int counter = 10;
    void Start()
    {
       InvokeRepeating(nameof(CountDown), 1.0f, 1.0f); 
    }

    void CountDown()
    {
        Debug.Log(counter);
        counter = counter - 1;
        if (counter == 0)
            {
                CancelInvoke();
                Debug.Log("Times up!");
            }

    }

    
}
