
using UnityEngine;
using UnityEngine.SceneManagement;


public class GManage : MonoBehaviour
{
    bool isGameEnd = false;
    public float delay = 1f;
    public GameObject completeLevelUI;
    public void CompleteLevel()
    {
        //Debug.Log("Won Level 1");
        completeLevelUI.SetActive(true);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void EndGame()
    {
        if (isGameEnd == false)
        {
            isGameEnd = true;
            Debug.Log("End");
            Invoke("Restart",delay);
        }
    }
    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//To load the current scene
    }
}
