using UnityEngine;

public class SphereMaker : MonoBehaviour
{
    public static void makeSphere(Vector3 position, Transform prefab)
    {
        Transform newSphere = Instantiate(prefab, position, Quaternion.identity);

    }
}