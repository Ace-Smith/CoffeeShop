using UnityEngine;

public class CalculatingValues : MonoBehaviour
{
    //Declaring variable _n as integer and assigning 24 to it
    private int _n = 24;

    void Start()
    {
        // assigning the value 4 to _n
        _n = 4;
        //Calls method with _n as a parameter
        CalculateForN(_n);
    }

    //method 
    void CalculateForN(int _n)
    {
        //outputs _n to debug log
        Debug.Log(_n);
        //Multiplies _n by 3 and assigns the answer to _n
        _n *= 3;
        //outputs _n to debug log
        Debug.Log(_n);
    }
    
}
