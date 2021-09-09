using UnityEngine;
using UnityEngine.SceneManagement;

public class Block : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
