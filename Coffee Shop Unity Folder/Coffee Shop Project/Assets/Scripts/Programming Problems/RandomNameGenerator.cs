using UnityEngine;

public class RandomNameGenerator : MonoBehaviour
{
   string[] names = { "Ben", "Maisie", "Rose", "Charlie", "Emily", "Elle"};
    private int index;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        { 
            int index = Random.Range(0, names.Length);
            Debug.Log(names[index]);
            
        }

    }
}
