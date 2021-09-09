using UnityEngine;

public class SnakeColorChanger : MonoBehaviour
{
    [SerializeField] private Color _startColor;
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void Start()
    {
        _renderer.material.color = _startColor;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<SnakeColor>(out SnakeColor snakeColor))
        {
            snakeColor.ChangeColor(_renderer.material.color);
        }
    }
}
