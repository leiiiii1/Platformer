using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScene : MonoBehaviour
{
    public string whichLevel;

    public void changeScene()
    {
        SceneManager.LoadScene(whichLevel);
    }
    public void exitGame()
    {
        Application.Quit();
    }
}
