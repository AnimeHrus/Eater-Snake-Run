using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeColor : MonoBehaviour
{
    private Renderer _renderer;

    private void Awake()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void ChangeColor(Color newColor)
    {
        _renderer.material.color = newColor;
    }
}
