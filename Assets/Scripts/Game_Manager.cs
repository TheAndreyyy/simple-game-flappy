using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour
{
    public GameObject Game_Over_Canvas;

    void Start()
    {
        Time.timeScale = 1;
    }

    public void Game_Over()
    {
        Game_Over_Canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }
}
