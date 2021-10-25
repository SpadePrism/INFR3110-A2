using UnityEngine;

public class InputWall : MonoBehaviour
{
    private Camera maincam;
    private RaycastHit hitInfo;
    public Transform cubePrefab;
    public Transform spherePrefab;
    private ProductFactory factory;
    public bool Spawning;
    public bool deathball;
    public bool deathcube;
    // public UIButton button;

    private void Awake()
    {
        maincam = Camera.main;
        Spawning = false;
        deathcube = false;
        deathball = true;
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && deathball)
        {
            factory = new SphereFactory(new Vector3(81f, 6f, 0f), spherePrefab);
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() && Spawning)
            {
                hitInfo.point = new Vector3(hitInfo.point.x, hitInfo.point.y, 0f);
                factory.MakeProduct(hitInfo.point);
                Debug.Log("Tag = " + hitInfo.point);
            }
        }

        if (Input.GetMouseButtonDown(0) && deathcube)
        {
            factory = new SphereFactory(new Vector3(81f, 6f, 0f), cubePrefab);
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity) && !UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject() && Spawning)
            {
                hitInfo.point = new Vector3(hitInfo.point.x, hitInfo.point.y, 0f);
                factory.MakeProduct(hitInfo.point);

                //ICommand command = new PlaceDeathCommand(hitInfo.point, cubePrefab);
                //Invoker.AddCommand(command);
                Debug.Log("Tag = " + hitInfo.point);
            }
        }
    }

    public void Toggle()
    {
        Spawning = !Spawning;
    }

    public void Swap()
    {
        //deathball = true;
        //deathcube = false;
        deathball = !deathball;
        deathcube = !deathcube;
    }
}