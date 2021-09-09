using UnityEngine;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<PlayerWin>(out PlayerWin win))
        {
            win.Win();
        }
    }
}
