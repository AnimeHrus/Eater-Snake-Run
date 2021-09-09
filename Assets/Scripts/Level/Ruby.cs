using UnityEngine;

public class Ruby : MonoBehaviour
{
    public delegate void RubyCollect();
    public static event RubyCollect OnRubyCollected;

    public void Destroy()
    {
        OnRubyCollected?.Invoke();
        Destroy(gameObject);
    }
}
