using UnityEngine;

public class SphereMaker : MonoBehaviour
{
    public static void makeSphere(Vector3 position, Transform sphere)
    {
        Transform newSphere = Instantiate(sphere, position, Quaternion.identity);
    }
}