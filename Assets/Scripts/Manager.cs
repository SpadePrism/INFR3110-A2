using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public Text ValueText;

    // Start is called before the first frame update
    private void Start()
    {
        //ValueText.text = DeathCount.Instance.Value.ToString();
    }

    private void Update()
    {
        ValueText.text = DeathCount.Instance.Value.ToString();
    }
}
