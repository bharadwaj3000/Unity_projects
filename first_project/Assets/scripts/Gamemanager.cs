
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
    
{

    bool gamehasended = false;
    public float delaytime = 2f;
    public void EndGame()
    {
        if (!gamehasended)
        {
            Debug.Log("Game Over");
            gamehasended = true;
            Invoke("restart", delaytime);
        }
    }

    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
