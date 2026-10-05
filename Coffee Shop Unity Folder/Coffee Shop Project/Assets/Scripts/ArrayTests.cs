using UnityEngine;
using System.Collections.Generic;

public class ArrayTests : MonoBehaviour
{
    // public GameObject[] gameObject;
    // public List<GameObject> gameObjectsList = new List<GameObject>();
    public float[] values;
   
    void Start()
    {
        // foreach (GameObject obj in gameObjectsList)
        // {
        //     Debug.Log("GameObject in List: " + obj.name);
        // }
      
        foreach (float value in values)
        {
            Debug.Log(value);
        }

      values = new float[10];
      values[1] = 5.0f;
     }
}
