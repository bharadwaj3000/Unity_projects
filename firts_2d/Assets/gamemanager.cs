using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    public void EngGame(){
        Time.timeScale = 1f / 10f;
        Time.fixedDeltaTime = Time.fixedDeltaTime / 10f;

        Invoke("restart", 1f / 10f);
    }

    void restart(){
        Time.timeScale = 1f;
        Time.fixedDeltaTime = Time.fixedDeltaTime * 10;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
