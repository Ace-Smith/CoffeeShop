using UnityEngine;

public class RestartButton : MonoBehaviour
{
    public GameObject Restart;
    
    void OnClick()
    {
        CheckCustomer.customersServed = 0;
        Restart.SetActive(false);
    }

}
