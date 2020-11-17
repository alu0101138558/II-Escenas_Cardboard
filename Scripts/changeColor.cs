using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Material colorEsfera;
    // Start is called before the first frame update
    void Start()
    {
        colorEsfera.color = new Color(1, 1, 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void changeActualColor (string color)
    {
        if (color == "red")
        {
            colorEsfera.color = new Color(1, 0, 0, 1);
        } else if (color == "blue")
        {
            colorEsfera.color = new Color(0, 0, 1, 1);
        } else if (color == "green")
        {
            colorEsfera.color = new Color(0, 1, 0, 1);
        }
    }

    private void OnDisable()
    {
        colorEsfera.color = new Color(1, 1, 1, 1);
    }
}
