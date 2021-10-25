using UnityEngine;

public class InputWall : MonoBehaviour
{
    private Camera maincam;
    private RaycastHit hitInfo;
    public Transform cubePrefab;
    public Transform cylinderPrefab;
    // public UIButton button;

    private void Awake()
    {
        maincam = Camera.main;
    }

    // Update is called once per frame
    private void Update()
    {
        //if (Input.GetMouseButtonDown(0))
        //{
        //    Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
        //    if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
        //    {
        //        hitInfo.point = new Vector3(hitInfo.point.x, hitInfo.point.y, 0f);
        //        ICommand command = new PlaceDeathCommand(hitInfo.point, cubePrefab);
        //        Invoker.AddCommand(command);
        //        Debug.Log("Tag = " + hitInfo.point);

        //    }
        //}
    }
}