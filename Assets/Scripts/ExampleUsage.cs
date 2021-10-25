using UnityEngine;

public class ExampleUsage : MonoBehaviour
{
    public Material Material1;
    public Transform spherePrefab;
    public Transform cubePrefab;

    private float type;

    private void Start()
    {
        type = Random.Range(1, 3); //1-2
        Debug.Log(type);
        //var factory = new SphereFactory(new Vector3(0f, 3.5f, 0f), spherePrefab);
        //factory.CreateShape();
        //factory.SetPosition(new Vector3(0f, 5.5f, 0f));

        ProductFactory factory;
        if (type == 1f)
        {
            //use factory to create deathballs
            factory = new SphereFactory(new Vector3(81f, 6f, 0f), spherePrefab);

            factory.MakeProduct();
            factory.MakeProduct(new Vector3(88.5f, 6f, 0f));
            factory.MakeProduct(new Vector3(97f, 5.5f, 0f));
            factory.MakeProduct(new Vector3(84.5f, 8.5f, 0f));
            factory.MakeProduct(new Vector3(93f, 9f, 0f));
            factory.MakeProduct(new Vector3(89f, 11f, 0f));//top 3
            factory.MakeProduct(new Vector3(80f, 11f, 0f));
            factory.MakeProduct(new Vector3(86f, 12.5f, 0f));
            factory.MakeProduct(new Vector3(84f, -0.25f, 0f));//bottom 2
            factory.MakeProduct(new Vector3(93.5f, -0.25f, 0f));

            /*
             IFactory ball1 = factory.MakeProduct();
             IFactory ball2 = factory.MakeProduct(new Vector3(88.5f, 6f, 0f));
             IFactory ball3 = factory.MakeProduct(new Vector3(97f, 5.5f, 0f));
             IFactory ball4 = factory.MakeProduct(new Vector3(84.5f, 8.5f, 0f));
             IFactory ball5 = factory.MakeProduct(new Vector3(93f, 9f, 0f));
             IFactory ball6 = factory.MakeProduct(new Vector3(89f, 11f, 0f));//top 3
             IFactory ball7 = factory.MakeProduct(new Vector3(80f, 11f, 0f));
             IFactory ball8 = factory.MakeProduct(new Vector3(86f, 12.5f, 0f));
             IFactory ball9 = factory.MakeProduct(new Vector3(84f, -0.25f, 0f));//bottom 2
             IFactory ball10 = factory.MakeProduct(new Vector3(93.5f, -0.25f, 0f));
            */
            Debug.Log("Ball Factory");
        }
        else if (type == 2f)
        {
            factory = new SphereFactory(new Vector3(81f, 6f, 0f), cubePrefab);
            factory.MakeProduct();
            factory.MakeProduct(new Vector3(88.5f, 6f, 0f));
            factory.MakeProduct(new Vector3(97f, 5.5f, 0f));
            factory.MakeProduct(new Vector3(84.5f, 8.5f, 0f));
            factory.MakeProduct(new Vector3(93f, 9f, 0f));
            factory.MakeProduct(new Vector3(89f, 11f, 0f));//top 3
            factory.MakeProduct(new Vector3(80f, 11f, 0f));
            factory.MakeProduct(new Vector3(86f, 12.5f, 0f));
            factory.MakeProduct(new Vector3(84f, -0.25f, 0f));//bottom 2
            factory.MakeProduct(new Vector3(93.5f, -0.25f, 0f));
            Debug.Log(" Cube Factory");
        }
        // Debug.Log("Factory");
    }
}