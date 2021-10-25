using UnityEngine;
using UnityEngine.UI;

public class GUIChanger : MonoBehaviour
{
    private Camera maincam;
    private RaycastHit hitInfo;
    public GameObject subject;

    // public Transform cubePrefab;
    // public Transform cylinderPrefab;
    public Button green;

    public Button yellow;
    public Button cyan;

    private void Awake()
    {
        maincam = Camera.main;
        green.gameObject.SetActive(false);
        yellow.gameObject.SetActive(false);
        cyan.gameObject.SetActive(false);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = maincam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                //Debug.Log("Hit " + hitInfo.transform.gameObject.name);
                if (hitInfo.transform.gameObject.tag == "Step")
                {
                    //Debug.Log("It's working!");
                    ICommand command = new SpawnButtonCommand(green);
                    Invoker.AddCommand(command);
                    ICommand command1 = new SpawnButtonCommand(yellow);
                    Invoker.AddCommand(command1);
                    ICommand command2 = new SpawnButtonCommand(cyan);
                    Invoker.AddCommand(command2);
                    subject = hitInfo.transform.gameObject;
                }
            }
        }
    }

    public void TurnGreen()
    {
        //Debug.Log("It's working!");
        subject.GetComponent<Renderer>().material.color = Color.green;
    }

    public void TurnYellow()
    {
        //Debug.Log("It's working!");
        subject.GetComponent<Renderer>().material.color = Color.yellow;
    }

    public void TurnCyan()
    {
        //Debug.Log("It's working!");
        subject.GetComponent<Renderer>().material.color = Color.cyan;
    }
}