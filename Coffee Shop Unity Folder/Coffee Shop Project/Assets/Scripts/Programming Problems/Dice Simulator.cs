using UnityEngine;

public class DiceSimulator : MonoBehaviour
{
    public float dice;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            float dice = Random.Range(1, 7);
            Debug.Log(dice);

            if (dice == 6)
            {
                Debug.Log("Critical Hit!");
            }
        }
    }
    
}
