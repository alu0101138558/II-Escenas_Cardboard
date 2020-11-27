using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualColor : MonoBehaviour
{
    // Start is called before the first frame update
    static private string AColor;

    public void saveColor (string color)
    {
        AColor = color;
    }

    static public string knowActualColor ()
    {
        return AColor;
    } 
}
