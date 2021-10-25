using UnityEngine;
using UnityEngine.UI;

public class GUIChanger : MonoBehaviour
{
    private Camera maincam;
    private RaycastHit hitInfo;

    // public Transform cubePrefab;
    // public Transform cylinderPrefab;
    public Button green;

    private void Awake()
    {
        maincam = Camera.main;
        green.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "Step")
                {
                    Debug.Log("It's working!");
                    green.gameObject.SetActive(true);
                }
                else
                {
                    Debug.Log("NO");
                }


            }
            else
            {
                Debug.Log("No hit");
            }
        }
    }
}