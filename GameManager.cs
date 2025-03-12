using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int hp;
    public int score;

    public void Update()
    {
        if(hp <= 0)
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
