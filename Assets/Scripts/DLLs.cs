using System.Runtime.InteropServices;
using UnityEngine;

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
    private void Start()
    {
        GetComponent<Renderer>().material.color = new Color(GetCol1(), GetCol2(), GetCol3());

        GetComponent<Move>().spdM = speedMod();
        GetComponent<Move>().gravityM = gravMod();
        GetComponent<Move>().jump = jumpMod();
        //Debug.Log(speedMod());
    }

    // Update is called once per frame
    private void Update()
    {
    }
}