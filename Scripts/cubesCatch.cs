using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cubesCatch : MonoBehaviour
{
    // Start is called before the first frame update
    public Text actualText;
    private int cubesInScene;
    void Start()
    {
        cubesInScene = actualCubesInScene();
    }

    // Update is called once per frame
    void Update()
    {
        int nCubesCath = cubesInScene - actualCubesInScene();
        actualText.text = "Número de cubos recolectados:  " + nCubesCath;
    }

    private int actualCubesInScene ()
    {
        GameObject[] cubos = GameObject.FindGameObjectsWithTag("Cube");
        return cubos.Length;
    }
}
