using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    private int _score = 0;
    private Text _text;

    private void Awake()
    {
        _text = GetComponent<Text>();
    }

    private void OnEnable()
    {
        HumanColor.OnHumanEated += AddHumanScore;
        Ruby.OnRubyCollected += AddRubyScore;
    }

    private void OnDisable()
    {
        HumanColor.OnHumanEated -= AddHumanScore;
        Ruby.OnRubyCollected -= AddRubyScore;
    }

    private void AddHumanScore()
    {
        _score++;
        _text.text = "Score: \n" + _score;
    }

    private void AddRubyScore()
    {
        _score += 5;
        _text.text = "Score: \n" + _score;
    }
}
