using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject BlackBackground;
    bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isPaused = !isPaused;

        }

        if (isPaused == true)
        {
            Time.timeScale = 0;
            BlackBackground.SetActive(true);
        }
        else
        {
            Time.timeScale = 1;
            BlackBackground.SetActive(false);
        }
    }

    public void PauseGame()
    {
            isPaused = !isPaused;
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void ChangeScene(int id)
    {
        SceneManager.LoadScene(id);
    }

    public void Lose()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
