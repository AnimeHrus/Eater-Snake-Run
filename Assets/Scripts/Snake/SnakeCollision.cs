using UnityEngine;

public class SnakeCollision : MonoBehaviour
{
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<Block>(out Block block))
        {
            block.RestartLevel();
        }
        if (other.TryGetComponent<HumanColor>(out HumanColor human))
        {
            if(_renderer.material.color == human.GetColor())
            {
                human.Destroy();
            }
            else
            {
                human.RestartLevel();
            }
        }
        if (other.TryGetComponent<Ruby>(out Ruby ruby))
        {
            ruby.Destroy();
        }
    }
}
