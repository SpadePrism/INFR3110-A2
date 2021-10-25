using UnityEngine;
using System;
using System.Runtime.InteropServices;

public class DLLs : MonoBehaviour
{

    [DllImport("MidtermDLL")]
    private static extern float GetCol1();

    [DllImport("MidtermDLL")]
    private static extern float GetCol2();

    [DllImport("MidtermDLL")]
    private static extern float GetCol3();

    [DllImport("A2DLL")]
    private static extern float speedMod();

    [DllImport("A2DLL")]
    private static extern float gravMod();

    [DllImport("A2DLL")]
    private static extern float jumpMod();

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Renderer>().material.color = new Color(GetCol1(), GetCol2(), GetCol3());

        GetComponent<Move>().spdM = speedMod();
        GetComponent<Move>().gravityM = gravMod();
        GetComponent<Move>().jump = jumpMod();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
