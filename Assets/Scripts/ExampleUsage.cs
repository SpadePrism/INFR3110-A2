using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    public Material Material1;
    public Transform spherePrefab;
    public Transform cubePrefab;

    private void Start()
    {
        //var factory = new SphereFactory(new Vector3(0f, 3.5f, 0f), spherePrefab);
        //factory.CreateShape();
        //factory.SetPosition(new Vector3(0f, 5.5f, 0f));
        //factory.CreateShape();

        ProductFactory factory = new SphereFactory(new Vector3(0f, 3.5f, 0f), spherePrefab);
        IFactory ball1 = factory.MakeProduct();

        IFactory ball2 = factory.MakeProduct(new Vector3(0f, 5.5f, 0f));

        IFactory ball3 = factory.MakeProduct(new Vector3(0f, 7.5f, 0f));
        IFactory ball4 = factory.MakeProduct(new Vector3(0f, 10.5f, 0f));

        // Debug.Log("Factory");
    }
}