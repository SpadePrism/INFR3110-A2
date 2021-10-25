using UnityEngine;
using UnityEngine.UI;

public class DeathCount : MonoBehaviour
{
    public static DeathCount Instance { get; private set; }

    public int Value;
    private Text _text;

    private void Awake()
    {
        Value = 0;
        _text = GetComponent<Text>();
        if (Instance == null)
        {
            DontDestroyOnLoad(gameObject);
        }
        Instance = this;
        if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void died()
    {
        Value++;
        _text.text = "Deaths: " + Value.ToString();
    }
}