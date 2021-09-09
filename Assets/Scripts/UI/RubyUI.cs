using UnityEngine;
using UnityEngine.UI;

public class RubyUI : MonoBehaviour
{
    private int _ruby = 0;
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        Ruby.OnRubyCollected += AddRubyCount;
    }

    private void OnDisable()
    {
        Ruby.OnRubyCollected -= AddRubyCount;
    }

    private void AddRubyCount()
    {
        _ruby++;
        _text.text = "Ruby: \n" + _ruby;
    }
}
