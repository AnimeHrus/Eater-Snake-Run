using UnityEngine;

public class SnakeCrawl : MonoBehaviour
{
    [SerializeField] private float _speed = 3f;
    [SerializeField] private Vector3 _direction = new Vector3(0, 0, 1);

    private void Update()
    {
        MoveDirection();
    }

    private void MoveDirection()
    {
        transform.Translate(_direction * _speed * Time.deltaTime);
    }
}
