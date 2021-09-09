using System.Collections.Generic;
using UnityEngine;

public class SnakeTail : MonoBehaviour
{
    [SerializeField] private Transform _snakeHead;
    [SerializeField] private GameObject _snakeTail;
    [SerializeField] private GameObject _snakeBodyRing;
    [SerializeField] private int _tailCount = 5;
    private float _TailLength = 1f;
    private List<Transform> _snakeTails = new List<Transform>();
    private List<Vector3> _tailPositions = new List<Vector3>();

    private void Awake()
    {
        _tailPositions.Add(_snakeHead.position);
    }

    private void Start()
    {
        for (int spawnedTail = 0; spawnedTail < _tailCount; spawnedTail++)
        {
            AddTail();
        }
    }

    private void Update()
    {
        float distance = (_snakeHead.position - _tailPositions[0]).magnitude;
        if (distance > _TailLength)
        {
            Vector3 direction = (_snakeHead.position - _tailPositions[0]).normalized;
            _tailPositions.Insert(0, _tailPositions[0] + direction * _TailLength);
            _tailPositions.RemoveAt(_tailPositions.Count - 1);
            distance -= _TailLength;
        }
        for (int movedTail = 0; movedTail < _snakeTails.Count; movedTail++)
        {
            _snakeTails[movedTail].position = Vector3.Lerp(_tailPositions[movedTail + 1], _tailPositions[movedTail], distance / _TailLength);
        }
    }

    private void AddTail()
    {
        GameObject tail = Instantiate(_snakeTail, _tailPositions[_tailPositions.Count - 1], Quaternion.identity, transform);
        tail.transform.Translate(Vector3.back);
        GameObject ring = Instantiate(_snakeBodyRing, tail.transform.position, Quaternion.identity, transform);
        ring.transform.Translate(Vector3.forward * 0.5f);
        ring.transform.SetParent(tail.transform);
        _snakeTails.Add(tail.transform);
        _tailPositions.Add(tail.transform.position);
    }
}
