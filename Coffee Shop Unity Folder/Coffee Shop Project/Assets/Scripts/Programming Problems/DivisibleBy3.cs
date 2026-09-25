using UnityEngine;

public class DivisibleBy3 : MonoBehaviour
{
   
  [SerializeField] private int num = 15;
  public bool divisible = false;
  [SerializeField] private int divisor = 3;


    void Start()
    {
        divisible = CanDivide(num, divisor);

        Debug.Log(num + " is " + divisible);
    }

    public bool CanDivide(int num, int divisor)
    {
        return num % divisor == 0;
    }




}
