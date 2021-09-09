using UnityEngine;
using UnityEngine.SceneManagement;

public class HumanColor : MonoBehaviour
{
    [SerializeField] private Color _startColor;
    private Renderer _renderer;
    public delegate void EatingHuman();
    public static event EatingHuman OnHumanEated;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.color = _startColor;
    }

    public Color GetColor()
    {
        return _renderer.material.color;
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Destroy()
    {
        OnHumanEated?.Invoke();
        Destroy(gameObject);
    }
}
