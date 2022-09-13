using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class MenuHandler : MonoBehaviour
{
    public int sceneIndex;
    public Button play;
    public Button quit;
   
   
   
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneIndex);

    }

    public void exitGame()
    {
        Application.Quit();
    }

}
