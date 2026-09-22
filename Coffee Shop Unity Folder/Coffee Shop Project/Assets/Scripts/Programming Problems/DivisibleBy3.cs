using UnityEngine;

public class DivisibleBy3 : MonoBehaviour
{
   
  [SerializeFeild] int num = 15;
  public bool divisible = false;
  public int divisor = 3;

//   divisible = CanDivide(_num, divisor, divisible);

//   Debug.Log(divisible);

//   public bool CanDivide (int _num, int divisor, bool divisible)  
//   {
  

//     Return 
//   }


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
