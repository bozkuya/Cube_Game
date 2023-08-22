
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public bool GameHasEnded = false;
    public float Delay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        Debug.Log("leven won");
        completeLevelUI.SetActive(true);
    }
    public void EndGame()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Debug.Log("game over");
            Invoke("Restart", Delay);
        }
      
        
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    void Start()
    {
        completeLevelUI.SetActive(false);
    }

}
