using UnityEngine;
using System.Collections;

public class Coroutines : MonoBehaviour
{
    public float num = 4.5f;

    private void Start()
    {
        StartCoroutine(MakeCoffee());
    }
    private IEnumerator MakeCoffee()
    {
        yield return new WaitForSeconds(num);
        Debug.Log("Coffee ready!");
    }
}
