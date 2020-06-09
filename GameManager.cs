using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 0.5f;
    public GameObject completeLevelUI;
    public PlayerMovement movement;
    public LevelComplete level;
    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
        movement.enabled = false;
        level.LoadNextLevel();

    }
    public void EndGame()
     
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}