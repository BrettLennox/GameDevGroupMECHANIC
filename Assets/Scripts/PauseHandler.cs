using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseHandler : MonoBehaviour
{
    public Button pauseButton;
    public Text score;
    public int sceneIndex;
    public Button mainMenu;
    public int scoreValue = 0;
    public Text scoreText;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneIndex);

    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ResumeGame()
    {
        Time.timeScale = 1;
    }

}
