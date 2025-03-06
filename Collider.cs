using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collider : MonoBehaviour
{
    public GameManager gameManager;
    public string whichGameObject;
    public string whichLevel;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(whichGameObject == "Harming")
        {
            gameManager.hp -= 5;
        }
        else if (whichGameObject == "teleport")
        {
            SceneManager.LoadScene(whichLevel);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (whichGameObject == "Harming")
        {
            gameManager.hp -= 5;
        }
        else if (whichGameObject == "collectible")
        {
            gameManager.score += 1;
            gameObject.SetActive(false);
        }
    }
}
