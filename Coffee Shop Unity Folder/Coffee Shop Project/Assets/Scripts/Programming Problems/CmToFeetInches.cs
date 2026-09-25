using System;
using UnityEngine;

public class CmToFeetInches : MonoBehaviour
{
    //Declaring Cm as a public so it can be changed in inspector menu
    public int CM = 254;
    //Declaring Inches as a float so the division assignment with a float doesnt produce errors
    private float Inches;
    //Declaring Feet as integer as the output needs to be an integer
    private int Feet;
    //Declaring a new inches variable as an integer as the output needs to be an integer
    private int inchesInt;

    private void Start()
    {
        //Calling the method with CM as the parameter
        CmToFeet(CM);
    }

    //Method signiture
    public void CmToFeet(int CM)
    {
        //Calculating the total number of inches 
        Inches = CM / 2.54f;
        //Casting the total number of inches into a whole number for next calculations
        int inchesInt = (int)Inches;
        //Calculating number of feet in the total number of inches
        Feet = inchesInt / 12;
        //Calculating the remainder of inches left after working out number of feet
        inchesInt = inchesInt % 12;

        //Outputing convertion into the debug menu
        Debug.Log(CM + "cm is " + Feet + "feet and " + inchesInt +"inches to the neartest inch.");
    }
}
