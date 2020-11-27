using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{
    public Material colorEsfera;
    private Renderer esfera;
    // Start is called before the first frame update
    void Start()
    {
        esfera = GetComponent<Renderer>();
        esfera.material.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void changeActualColor ()
    {
        if (ActualColor.knowActualColor() == "red")
        {
            esfera.material.color = Color.red;
        } else if (ActualColor.knowActualColor() == "blue")
        {
            esfera.material.color = Color.blue;
        } else if (ActualColor.knowActualColor() == "green")
        {
            esfera.material.color = Color.green;
        }
    }

    private void OnDisable()
    {
        esfera.material.color = Color.white;
    }
}
